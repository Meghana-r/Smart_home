  #include "dht.h"

dht DHT;
int curVal;

#define LIGHT1LEVEL1 3
#define LIGHT1LEVEL2 4
#define LIGHT1LEVEL3 5

#define LIGHT2LEVEL1 6
#define LIGHT2LEVEL2 7
#define LIGHT2LEVEL3 8

#define LIGHT3LEVEL1 9
#define LIGHT3LEVEL2 10
#define LIGHT3LEVEL3 11

#define TV 13

#define DHTPIN 12

void setup(){
  Serial.begin(9600);
  pinMode(LIGHT1LEVEL1,OUTPUT);
  pinMode(LIGHT1LEVEL2,OUTPUT);
  pinMode(LIGHT1LEVEL3,OUTPUT);
  
  pinMode(LIGHT2LEVEL1,OUTPUT);
  pinMode(LIGHT2LEVEL2,OUTPUT);
  pinMode(LIGHT2LEVEL3,OUTPUT);
  
  pinMode(LIGHT3LEVEL1,OUTPUT);
  pinMode(LIGHT3LEVEL2,OUTPUT);
  pinMode(LIGHT3LEVEL3,OUTPUT);
  
  pinMode(TV,OUTPUT);
  pinMode(DHTPIN,OUTPUT);
  
}

void loop()
{
  int chk = DHT.read11(DHTPIN);
  Serial.print(DHT.temperature);
  Serial.print(" and ");
  Serial.println(DHT.humidity);
  if (Serial.available() > 0)
  {
    curVal = Serial.parseInt();  
  }
	switch (curVal) 
	{	
		case 0: digitalWrite(LIGHT1LEVEL1, LOW); // ALL LIGHT 1 LOW
				digitalWrite(LIGHT1LEVEL2, LOW);
				digitalWrite(LIGHT1LEVEL3, LOW);
				break;
		case 1: digitalWrite(LIGHT2LEVEL1, LOW); // ALL LIGHT 2 LOW
				digitalWrite(LIGHT2LEVEL2, LOW);
				digitalWrite(LIGHT2LEVEL3, LOW);
				break;	
		case 2: digitalWrite(LIGHT3LEVEL1, LOW); // ALL LIGHT 3 LOW
				digitalWrite(LIGHT3LEVEL2, LOW);
				digitalWrite(LIGHT3LEVEL3, LOW);
				break;		
		case 3: digitalWrite(LIGHT1LEVEL1, HIGH); // LIGHT 1 LEVEL 1
				digitalWrite(LIGHT1LEVEL2, LOW);
				digitalWrite(LIGHT1LEVEL3, LOW);
				break;
		case 4: digitalWrite(LIGHT1LEVEL1, HIGH); // LIGHT 1 LEVEL 2
				digitalWrite(LIGHT1LEVEL2, HIGH);
				digitalWrite(LIGHT1LEVEL3, LOW);
				break;	
		case 5: digitalWrite(LIGHT1LEVEL1, HIGH); // LIGHT 1 LEVEL 3
				digitalWrite(LIGHT1LEVEL2, HIGH);
				digitalWrite(LIGHT1LEVEL3, HIGH);
				break;			
		case 6: digitalWrite(LIGHT2LEVEL1, HIGH); // LIGHT 2 LEVEL 1
				digitalWrite(LIGHT2LEVEL2, LOW);
				digitalWrite(LIGHT2LEVEL3, LOW);
				break;					
		case 7: digitalWrite(LIGHT2LEVEL1, HIGH); // LIGHT 2 LEVEL 2
				digitalWrite(LIGHT2LEVEL2, HIGH);
				digitalWrite(LIGHT2LEVEL3, LOW);
				break;	
		case 8: digitalWrite(LIGHT2LEVEL1, HIGH); // LIGHT 2 LEVEL 3
				digitalWrite(LIGHT2LEVEL2, HIGH);
				digitalWrite(LIGHT2LEVEL3, HIGH);
				break;			
		case 9: digitalWrite(LIGHT3LEVEL1, HIGH); // LIGHT 3 LEVEL 1
				digitalWrite(LIGHT3LEVEL2, LOW);
				digitalWrite(LIGHT3LEVEL3, LOW);
				break;	
		case 10: digitalWrite(LIGHT3LEVEL1, HIGH); // LIGHT 3 LEVEL 2
				digitalWrite(LIGHT3LEVEL2, HIGH);
				digitalWrite(LIGHT3LEVEL3, LOW);
				break;			
		case 11: digitalWrite(LIGHT3LEVEL1, HIGH); // LIGHT 3 LEVEL 3
				digitalWrite(LIGHT3LEVEL2, HIGH);
				digitalWrite(LIGHT3LEVEL3, HIGH);
				break;	
		case 12: digitalWrite(TV, HIGH); // TV HIGH
				 break;
		case 13: digitalWrite(TV, LOW);  // TV LOW
	}
  
  delay(1000);
   
 
}

