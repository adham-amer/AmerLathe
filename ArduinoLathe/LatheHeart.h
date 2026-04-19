#ifndef STEPPER_ISR_H
#define STEPPER_ISR_H

#include <Arduino.h>
#include <stdint.h>

#define ISR_FREQ 20000UL // 20 kHz

struct Packet
{
  byte CMD;
  byte DIR;
  uint16_t XSTEPS; // X Axis steps
  uint16_t ZSTEPS; // Z Axis steps
  uint16_t SSPEED; // Spindle speed
  uint16_t FRATE;  // Feed Rate
  byte TAIL;
};

extern Packet Data;

void startBeat(void);

#endif
