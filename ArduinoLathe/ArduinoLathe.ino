struct Packet
{
  byte CMD; 
  uint16_t XSTEPS; // X Axis steps
  uint16_t ZSTEPS; // Z Axis steps
  uint16_t SSPEED; // Spindle speed
  uint16_t FRATE; // Feed Rate
  byte TAIL; 
};



Packet p1;
void setup() {
  // put your setup code here, to run once:
Serial.begin(115200);

}

void loop() {
  
  while (Serial.available()) {
    if (Serial.available() >= sizeof(Packet)) {
      Serial.readBytes(reinterpret_cast<char*>(&p1), sizeof(Packet));
      Serial.write(reinterpret_cast<uint8_t*>(&p1.XSTEPS), sizeof(p1.XSTEPS));
    }
  }
delay(1000);
}
