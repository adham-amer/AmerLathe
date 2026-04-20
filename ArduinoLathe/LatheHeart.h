#ifndef STEPPER_ISR_H
#define STEPPER_ISR_H

#include <Arduino.h>
#include <stdint.h>

#define ISR_FREQ 20000UL // 20 kHz

struct __attribute__((packed)) Packet
{
  byte CMD;
  byte DIR;
  uint32_t XSTEPS; // X Axis steps
  uint32_t ZSTEPS; // Z Axis steps
  uint16_t SSPEED; // Spindle speed
  uint16_t FRATE;  // Feed Rate
  byte TAIL;
};

struct __attribute__((packed)) PacketFromFirmware
{
  uint32_t XPOS;
  uint32_t ZPOS;
  uint16_t SSPEED;
  uint16_t SPOS;
  byte IOs;
  byte TAIL;
};

constexpr size_t PacketSize = sizeof(Packet);
constexpr size_t PacketFromFirmwareSize = sizeof(PacketFromFirmware);

extern Packet Data;
extern PacketFromFirmware FirmwareData;

void startBeat(void);

#endif
