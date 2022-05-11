# Detector de Humo/Gas/Calor

## Ejemplo codigo Pic

El código que se utilizó para el pic para esta simulación es:

```C
#include<16f887.h>
#fuses INTRC_IO,NOWDT,PROTECT,NOLVP,MCLR,NOBROWNOUT
#device ADC=10
#use delay(INTERNAL=4000000)
#use RS232(baud=9600,xmit=PIN_C6,rcv=PIN_C7, timeout = 100)
#include"lcd.h"

boolean get_gas_status (){
   return input(PIN_A1);
}

int16 get_temperatura(){
   return read_adc()*500/1023;
}

void imprimir_datos(int16 gas, int16 temperatura, char led, boolean buzzer, boolean peligro){
   printf(lcd_putc, "\fC:%Lu ,ppm:%Lu ",temperatura, gas);
   printf(lcd_putc, "\nB:%d ,LED:%c ",buzzer, led);
   printf("data,%Lu,%Lu,%c,%d,%d\n\r", gas, temperatura, led, buzzer, peligro);
}

void main(){

   // inicializamos la configuracion necesaria
   // Pantalla LCD
   lcd_init(); //Iniciamos pantalla 
   setup_adc_ports(sAN0); // el puerto sAN0 como analogico
   setup_adc(ADC_CLOCK_INTERNAL); // Módulo ADC utiliza su oscilador interno
   set_adc_channel(0); // seleccionamos el canal sAN0 para que sea donde lea el adc
   
   // creacion de variables que utilizaremos
   // mq2 gas sensor
   boolean ppm;
   // LM35 sensor de temperatura
   int16 temperatura;
   // led
   char color = 'V';
   // buzzer
   boolean buzzer = False;
   // variables para funcionamiento del buzzer y api
   boolean peligro = False;
   boolean alarma = False;
   boolean enviar = False;
   
   // variables para el funcionamiento general
   char modo = 'A';
   char instruccion;
   
   while(true){ // while para que siempre se ejecute el codigo
      switch(modo){ // switch para comprobar en que modo estamos
         case 'A': // modo Automatico
            // espera la instruccion para Cambiar de modo
            instruccion = getch();
            // captura de datos
            temperatura = get_temperatura();
            ppm = get_gas_status();
            // if para hacer x accion dependiendo de los datos capturados
            if( temperatura <= 30 && ppm == false ){
               
               // definir informacion para su posterior envio
               color = 'V';
               buzzer = False;
               peligro = False;
               
               // resetear variables para uso general
               alarma = False;
               enviar = False;
              
               // cambiar estado buzzer
               output_low(PIN_B3);
               
               // cambiar LED a VERDE
               output_high(PIN_B1);
               output_low(PIN_B2);
               output_low(PIN_B0);
               
            } else if( temperatura <= 39 && ppm == true ){
               
               // definir informacion para su posterior envio
               color = 'A';
               buzzer = False;
               peligro = False;
               
               // resetear variables para uso general
               enviar = False;
               
               //ruido del buzzer
               if (!alarma){
                  //emitir pitido de advertencia
                  output_high(PIN_B3);
                  delay_ms(300);
                  output_low(PIN_B3);
                  delay_ms(300);
                  output_high(PIN_B3);
                  delay_ms(300);
                  output_low(PIN_B3);
                  alarma = true;
               }
               
               // cambiar LED a Amarillo
               output_high(PIN_B1);
               output_low(PIN_B2);
               output_high(PIN_B0);

            } else if( temperatura >= 40 || ppm == true){

               // definir informacion para su posterior envio
               color = 'R';
               buzzer = True;
               
               // resetear variables para uso general
               alarma = False;
               peligro = False;
               
               //emitir ruido de peligro
               output_high(PIN_B3);
               
               //cambiar LED a Rojo
               output_low(PIN_B1);
               output_low(PIN_B2);
               output_high(PIN_B0);
               
               if (!enviar){
                  peligro = True;
                  enviar = True;
               }
               
            } else {
            }
            
            // impresion de datos, tanto en pantalla LCD como en Serial
            imprimir_datos(ppm, temperatura, color, buzzer, peligro);         
            
            // cambiar al modo manual
            if (instruccion == 'M') {
               modo = 'M';
               alarma = False;
               peligro = False;
            }
            
            break; // fin caso automatico
         
         case 'M': // modo Manual
         
            // espera la instruccion para saber que hacer
            instruccion = getch();
            
            // captura de datos
            temperatura = get_temperatura();
            ppm = get_gas_status();
            
            // if para cambiar estados por la instruccion ingresada
            if (instruccion == 'A') {
               modo = 'A';
               buzzer = False;
               alarma = False;
               peligro = False;
            } else if (instruccion == 'P'){
               buzzer = True;
            }else if (instruccion == 'O'){
               buzzer = False;
            }else if (instruccion == 'V'){
               color = 'V';
            }else if (instruccion == 'Y'){
               color = 'A';
            }else if (instruccion == 'R'){
               color = 'R';
            } else if (instruccion == 'D'){
               peligro = True;
            }
            
            // REALIZAR LAS ACCIONES DEPENDIENDO DE LA INSTRUCCION
            if ( color == 'V' && buzzer == False ) {
               // apagar buzzer
               output_low(PIN_B3);
               // cambiar LED a VERDE
               output_high(PIN_B1);
               output_low(PIN_B2);
               output_low(PIN_B0);
            } else if ( color == 'A' && buzzer == False ){
               // apagar buzzer
               output_low(PIN_B3);
               // cambiar LED a Amarillo
               output_high(PIN_B1);
               output_low(PIN_B2);
               output_high(PIN_B0);
            } else if ( color == 'R' && buzzer == False ){
               // apagar buzzer
               output_low(PIN_B3);
               //cambiar LED a Rojo
               output_low(PIN_B1);
               output_low(PIN_B2);
               output_high(PIN_B0);
            } else if ( color == 'V' && buzzer == True ){
               // prender buzzer
               output_high(PIN_B3);
               // cambiar LED a VERDE
               output_high(PIN_B1);
               output_low(PIN_B2);
               output_low(PIN_B0);
            } else if ( color == 'A' && buzzer == True ){
               // prender buzzer
               output_high(PIN_B3);
               // cambiar LED a Amarillo
               output_high(PIN_B1);
               output_low(PIN_B2);
               output_high(PIN_B0);
            } else if ( color == 'R' && buzzer == True ){
               // prender buzzer
               output_high(PIN_B3);
               //cambiar LED a Rojo
               output_low(PIN_B1);
               output_low(PIN_B2);
               output_high(PIN_B0);
            } 
            
            // impresion de datos tanto en el puerto serie como en pantalla LCD
            imprimir_datos(ppm, temperatura, color, buzzer, peligro);
            peligro = False;
            
            break; // fin caso Manual
            
      } // fin switch
   } // fin while true
} // fin main
```

archivo lcd

```C
///////////////////////////////////////////////////////////////////////////
////                             LCDD.C                                ////
////                 Driver for common LCD modules                     ////
////                                                                   ////
////  lcd_init()   Must be called before any other function.           ////
////                                                                   ////
////  lcd_putc(c)  Will display c on the next position of the LCD.     ////
////                     The following have special meaning:           ////
////                      \f  Clear display                            ////
////                      \n  Go to start of second line               ////
////                      \b  Move back one position                   ////
////                                                                   ////
////  lcd_gotoxy(x,y) Set write position on LCD (upper left is 1,1)    ////
////                                                                   ////
////  lcd_getc(x,y)   Returns character at position x,y on LCD         ////
////                                                                   ////
///////////////////////////////////////////////////////////////////////////
////        (C) Copyright 1996,2003 Custom Computer Services           ////
//// This source code may only be used by licensed users of the CCS C  ////
//// compiler.  This source code may only be distributed to other      ////
//// licensed users of the CCS C compiler.  No other use, reproduction ////
//// or distribution is permitted without written permission.          ////
//// Derivative programs created using this software in object code    ////
//// form are not restricted in any way.                               ////
///////////////////////////////////////////////////////////////////////////

// As defined in the following structure the pin connection is as follows:
//     D0  enable
//     D1  rs
//     D2  rw
//     D4  D4
//     D5  D5
//     D6  D6
//     D7  D7
//
//   LCD pins D0-D3 are not used and PIC D3 is not used.

// Un-comment the following define to use port B
// #define use_portb_lcd TRUE

struct lcd_pin_map {                 // This structure is overlayed
           BOOLEAN enable;           // on to an I/O port to gain
           BOOLEAN rs;               // access to the LCD pins.
           BOOLEAN rw;               // The bits are allocated from
           BOOLEAN unused;           // low order up.  ENABLE will
           int     data : 4;         // be pin B0.
        } lcd;


#if defined use_portb_lcd
   //#locate lcd = getenv("sfr:PORTB")    // This puts the entire structure over the port
   #ifdef __pch__
    #locate lcd = 0xf81
   #else
    #locate lcd = 6
   #endif
   #define set_tris_lcd(x) set_tris_b(x)
#else
   //#locate lcd = getenv("sfr:PORTD")    // This puts the entire structure over the port
   #ifdef __pch__
    #locate lcd = 0xf83
   #else
    #locate lcd = 8
   #endif
   #define set_tris_lcd(x) set_tris_d(x)
#endif


#define lcd_type 2           // 0=5x7, 1=5x10, 2=2 lines
#define lcd_line_two 0x40    // LCD RAM address for the second line


BYTE const LCD_INIT_STRING[4] = {0x20 | (lcd_type << 2), 0xc, 1, 6};
                             // These bytes need to be sent to the LCD
                             // to start it up.


                             // The following are used for setting
                             // the I/O port direction register.

struct lcd_pin_map const LCD_WRITE = {0,0,0,0,0}; // For write mode all pins are out
struct lcd_pin_map const LCD_READ = {0,0,0,0,15}; // For read mode data pins are in



BYTE lcd_read_byte() {
      BYTE low,high;
      set_tris_lcd(LCD_READ);
      lcd.rw = 1;
      delay_cycles(1);
      lcd.enable = 1;
      delay_cycles(1);
      high = lcd.data;
      lcd.enable = 0;
      delay_cycles(1);
      lcd.enable = 1;
      delay_us(1);
      low = lcd.data;
      lcd.enable = 0;
      set_tris_lcd(LCD_WRITE);
      return( (high<<4) | low);
}


void lcd_send_nibble( BYTE n ) {
      lcd.data = n;
      delay_cycles(1);
      lcd.enable = 1;
      delay_us(2);
      lcd.enable = 0;
}


void lcd_send_byte( BYTE address, BYTE n ) {

      lcd.rs = 0;
      while ( bit_test(lcd_read_byte(),7) ) ;
      lcd.rs = address;
      delay_cycles(1);
      lcd.rw = 0;
      delay_cycles(1);
      lcd.enable = 0;
      lcd_send_nibble(n >> 4);
      lcd_send_nibble(n & 0xf);
}


void lcd_init() {
    BYTE i;
    set_tris_lcd(LCD_WRITE);
    lcd.rs = 0;
    lcd.rw = 0;
    lcd.enable = 0;
    delay_ms(15);
    for(i=1;i<=3;++i) {
       lcd_send_nibble(3);
       delay_ms(5);
    }
    lcd_send_nibble(2);
    for(i=0;i<=3;++i)
       lcd_send_byte(0,LCD_INIT_STRING[i]);
}


void lcd_gotoxy( BYTE x, BYTE y) {
   BYTE address;

   if(y!=1)
     address=lcd_line_two;
   else
     address=0;
   address+=x-1;
   lcd_send_byte(0,0x80|address);
}

void lcd_putc( char c) {
   switch (c) {
     case '\f'   : lcd_send_byte(0,1);
                   delay_ms(2);
                                           break;
     case '\n'   : lcd_gotoxy(1,2);        break;
     case '\b'   : lcd_send_byte(0,0x10);  break;
     default     : lcd_send_byte(1,c);     break;
   }
}

char lcd_getc( BYTE x, BYTE y) {
   char value;

    lcd_gotoxy(x,y);
    while ( bit_test(lcd_read_byte(),7) ); // wait until busy flag is low
    lcd.rs=1;
    value = lcd_read_byte();
    lcd.rs=0;
    return(value);
}
```


