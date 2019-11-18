
#include <IRremote.h>

#include <IRremote.h>
int receptor = 10;
 int LED1 = 2;//Pieza1
 int LED2 = 13;//Baño1
 int LED3 = 4;//Sala1
 int LED4 = 5;//Garaje
 int LED5 = 6;//piscina
 int LED6 = 7;//
 int LED7 = 8;//
 int BOMBA = 9;//
 IRrecv irrecv(receptor);
decode_results codigo; //OBJETO CODIGO DE CLASE decode_result, oriundo de IRremote.h
void setup()
{
   Serial.begin(9600);
   irrecv.enableIRIn(); // INICIA LA RECEPCIÓN
   pinMode(LED1, OUTPUT);
   pinMode(LED2, OUTPUT);
   pinMode(LED3, OUTPUT);
   pinMode(LED4, OUTPUT);
   pinMode(LED5, OUTPUT);
   pinMode(LED6, OUTPUT);
   pinMode(LED7, OUTPUT);
   pinMode(BOMBA, OUTPUT);
}
 
void loop() {
   if (irrecv.decode(&codigo))
 {
Serial.println(codigo.value, HEX);

      if (codigo.value==0x5A0B421A)//CÓDIGO DEL NÚMERO CERO PARA ACTIVAR LED
      {
         digitalWrite(LED1,HIGH);
        
      }

      if (codigo.value==0x4A0B401A)//CÓDIGO DEL NÚMERO UNO PARA DESACTIVAR LED
      {
         digitalWrite(LED1,LOW);
      }
    
delay(500);
irrecv.resume();

 }
   if (Serial.available() > 0)
   {
      int option = Serial.read();
      //a de encendido LED1
      if (option == 'a')
      {
         digitalWrite(LED1, HIGH);
      }
      //b de apagado  LED1
      if (option == 'b')
      {
         digitalWrite(LED1, LOW);
      }
      //c de encendido LED2
      if (option == 'c')
      {
         digitalWrite(LED2, HIGH);
      }
      //d de apagado  LED2
      if (option == 'd')
      {
         digitalWrite(LED2, LOW);
      }
      //e de encendido LED3
      if (option == 'e')
      {
         digitalWrite(LED3, HIGH);
      }
      //f de apagado  LED3
      if (option == 'f')
      {
         digitalWrite(LED3, LOW);
      }
      //g de encendido LED4
      if (option == 'g')
      {
         digitalWrite(LED4, HIGH);
      }
      //h de apagado  LED4
      if (option == 'h')
      {
         digitalWrite(LED4, LOW);
      }
      //i de encendido LED5
      if (option == 'i')
      {
         digitalWrite(LED5, HIGH);
      }
      //j de apagado  LED5
      if (option == 'j')
      {
         digitalWrite(LED5, LOW);
      }
      //k de encendido LED6
      if (option == 'k')
      {
         digitalWrite(LED6, HIGH);
      }
      //h de apagado  LED6
      if (option == 'l')
      {
         digitalWrite(LED6, LOW);
      }
      //m de encendido LED7
      if (option == 'm')
      {
         digitalWrite(LED7, HIGH);
      }
      //n de apagado  LED7
      if (option == 'n')
      {
         digitalWrite(LED7, LOW);
      }
      //o de encendido BOMBA
      if (option == 'o')
      {
         digitalWrite(BOMBA, HIGH);
      }
      //p de apagado  BOMBA
      if (option == 'p')
      {
         digitalWrite(BOMBA, LOW);
      }
   }
}
