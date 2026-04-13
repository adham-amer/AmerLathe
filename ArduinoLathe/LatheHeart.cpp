#include <avr/io.h>
#include <avr/interrupt.h>
#include <stdlib.h>

// ===== CONFIG =====
#define ISR_FREQ 20000

// X axis pins (PORTD)
#define X_STEP PD2
#define X_DIR  PD3

// Y axis pins (PORTD)
#define Y_STEP PD4
#define Y_DIR  PD5

#include <avr/io.h>
#include <avr/interrupt.h>

// ISR is defined in stepper_isr.cpp
// just make sure it's compiled with this file

void startBeat()
{
    cli();
    TCCR1A = 0;
    TCCR1B = 0;
    TCCR1B |= (1 << WGM12);// CTC mode
    TCCR1B |= (1 << CS10); // prescaler = 1
    OCR1A = (16000000 / ISR_FREQ) - 1;  //   16Mhz / 20Khz and we sub 1 because it counts from 0 = 799
    TIMSK1 |= (1 << OCIE1A);// enable compare interrupt
    sei();
}

// ===== ISR =====
ISR(TIMER1_COMPA_vect)
{
    
}
