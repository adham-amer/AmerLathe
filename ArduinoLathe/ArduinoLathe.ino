#include "LatheHeart.h"

uint16_t x =0;


void setup() {
  // put your setup code here, to run once
  Serial.begin(115200);
  startBeat();

}

void loop() {
  
  while (Serial.available()) {
    if (Serial.available() >= sizeof(Packet)) {
      Serial.readBytes(reinterpret_cast<char*>(&Data), sizeof(Packet));
      //Serial.print("CMD: ");
     // Serial.println(Data.CMD);
      //Serial.print("DIR: ");
      //Serial.println(Data.DIR);
      //Serial.print("xsteps: ");
      //Serial.println(Data.XSTEPS);
      //Serial.pSrintln(((Data.XSTEPS & 0xff) << 8 + Data.XSTEPS>>8) );

      //FirmwareData.XPOS = Data.XSTEPS;
      //FirmwareData.ZPOS = Data.ZSTEPS;


       // write back to the GUI to confirm receipt of the packet
    }
  }


  //FirmwareData.XPOS += (1 - (((Data.DIR & 0x2) >> 1) << 1));
  //FirmwareData.ZPOS += (1 - (((Data.DIR & 0x8) >> 3) << 1));
  Serial.write(reinterpret_cast<uint8_t*>(&FirmwareData), sizeof(PacketFromFirmware));
  delay(20);
}
