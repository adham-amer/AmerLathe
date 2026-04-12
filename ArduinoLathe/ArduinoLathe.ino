struct Packet
{
  byte CMD; 
  uint16_t XSTEPS; // X Axis steps
  uint16_t ZSTEPS; // Z Axis steps
  uint16_t SSPEED; // Spindle speed
  uint16_t FRATE; // Feed Rate
  byte TAIL; 
};

uint16_t x =0;

Packet p1;
void setup() {
  // put your setup code here, to run once:
Serial.begin(115200);

}

void loop() {
  
  while (Serial.available()) {
    if (Serial.available() >= sizeof(Packet)) {
      Serial.readBytes(reinterpret_cast<char*>(&p1), sizeof(Packet));
      x+=p1.XSTEPS;
      Serial.write(reinterpret_cast<uint8_t*>(&x), sizeof(x));
    }
  }
//delay(1000);
}
