#include "LatheHeart.h"

#include <avr/io.h>
#include <avr/interrupt.h>
#include <stdlib.h>

// X axis pins (PORTB) 
#define X_STEP PB1 // PB1 ==> PIN 9
#define X_DIR  PB0 // PB0 ==> PIN 8

// Z axis pins (PORTB)
#define Z_STEP PB3 // PB3 ==> PIN 11
#define Z_DIR  PB2 // PB2 ==> PIN 10
#define TRIGGER_PIN Z_STEP

Packet Data;
PacketFromFirmware FirmwareData;



void startBeat()
{
    
    DDRB |= (1 << TRIGGER_PIN);
    PORTB &= ~(1 << TRIGGER_PIN);

    cli();
    TCCR1A = 0;
    TCCR1B = 0;
    TCCR1B |= (1 << WGM12);// CTC mode
    TCCR1B |= (1 << CS10); // prescaler = 1
    OCR1A = (16000000 / ISR_FREQ) - 1;  //   16Mhz / 20Khz and we sub 1 because it counts from 0 = 799
    TIMSK1 |= (1 << OCIE1A);// enable compare interrupt
    sei();
}

uint32_t XPOS = 0;
uint32_t ZPOS = 0;

uint32_t TC = 0;  //time 


bool Busy
;

// ===== ISR =====
ISR(TIMER1_COMPA_vect)
{

    if (Data.XSTEPS > 0) {

    }



    

    //PINB = (1 << TRIGGER_PIN);
    //st = !st;
    //digitalWrite(11,st);
    if (TC >= 10) {
        PINB = (1 << Z_STEP);
        TC=0;
    }
   
    TC++;
}
