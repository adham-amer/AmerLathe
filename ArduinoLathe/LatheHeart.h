#ifndef STEPPER_ISR_H
#define STEPPER_ISR_H

#include <stdint.h>
#define ISR_FREQ 20000UL //20Khz

// init
void stepper_timer1_init_20khz(void);

#endif
