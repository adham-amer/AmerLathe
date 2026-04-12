#include "latheheart.h"

#include <Arduino.h>
#include <avr/interrupt.h>
#include <stdint.h>

namespace LatheHeart {
namespace {
  namespace TimerConfig {
    const uint32_t interruptFrequencyHz = 20000UL;
    const uint16_t prescaler = 8;
  }

  volatile uint32_t isrTickCount = 0;
  volatile bool heartbeatFlag = false;

  void configureTimer1() {
    noInterrupts();

    TCCR1A = 0;
    TCCR1B = 0;
    TCNT1 = 0;

    const uint16_t compareValue =
        static_cast<uint16_t>((F_CPU / TimerConfig::prescaler / TimerConfig::interruptFrequencyHz) - 1UL);

    // CTC mode resets Timer1 whenever it reaches OCR1A.
    // That gives us a clean, fixed interrupt period for future step scheduling.
    OCR1A = compareValue;
    TCCR1B |= _BV(WGM12);

    // Start Timer1 with a prescaler of 8 on the Uno.
    TCCR1B |= _BV(CS11);

    // Fire the compare-match interrupt on every timer period.
    TIMSK1 |= _BV(OCIE1A);

    interrupts();
  }
}  // namespace

void begin() {
  Serial.begin(115200);
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);

  configureTimer1();

  Serial.println(F("LatheHeart timer core ready"));
}

void poll() {
  static uint32_t lastPrintedTick = 0;

  if (heartbeatFlag) {
    heartbeatFlag = false;
    digitalWrite(LED_BUILTIN, !digitalRead(LED_BUILTIN));
  }

  noInterrupts();
  uint32_t tickSnapshot = isrTickCount;
  interrupts();

  // Print occasionally from loop() so we can confirm the ISR is running
  // without doing slow serial work inside the interrupt itself.
  if (tickSnapshot - lastPrintedTick >= TimerConfig::interruptFrequencyHz) {
    lastPrintedTick = tickSnapshot;
    Serial.print(F("ticks="));
    Serial.println(tickSnapshot);
  }
}

void onTimerTick() {
  isrTickCount++;

  // Raise a lightweight flag every half second.
  // loop() can react to it later without blocking the ISR.
  if ((isrTickCount % (TimerConfig::interruptFrequencyHz / 2UL)) == 0) {
    heartbeatFlag = true;
  }
}
}  // namespace LatheHeart

ISR(TIMER1_COMPA_vect) {
  LatheHeart::onTimerTick();
}
