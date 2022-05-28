
int Enciende;
int A = 65;
int B = 69;
int C = 73;
int Pieza;

void setup() {
  // put your setup code here, to run once:

pinMode(3,OUTPUT);
pinMode(4,OUTPUT);
pinMode(5,OUTPUT);
pinMode(6,OUTPUT);
pinMode(7,OUTPUT);
pinMode(8,OUTPUT);
pinMode(9,OUTPUT);
pinMode(10,OUTPUT);
pinMode(11,OUTPUT);
pinMode(12,OUTPUT);
pinMode(A0,OUTPUT);
pinMode(A1,OUTPUT);
pinMode(A2,OUTPUT);
pinMode(A3,OUTPUT);
pinMode(A4,OUTPUT);
pinMode(A5,OUTPUT);
pinMode(A6,OUTPUT);
pinMode(A7,OUTPUT);



digitalWrite(3, LOW);
digitalWrite(4,LOW);
digitalWrite(5, LOW);
digitalWrite(6,LOW);
digitalWrite(7, LOW);
digitalWrite(8,LOW);
digitalWrite(9, LOW);
digitalWrite(10,LOW);
digitalWrite(11, LOW);
digitalWrite(12,LOW);
analogWrite(A0,0);
analogWrite(A1,0);
analogWrite(A2,0);
analogWrite(A3,0);
analogWrite(A4,0);
analogWrite(A5,0);
analogWrite(A6,0);
analogWrite(A7,0);


Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
if (Serial.available() > 0) {
// lee el byte de entrada:
Pieza = Serial.read();
Serial.print("Pieza: ");
Serial.println(Pieza,DEC);
delay(10);
Enciende = Serial.read();

//lo vuelca a pantalla
Serial.print("Enciende: ");
Serial.println(Enciende,DEC);

//Instrucciones para encender
 if (Enciende == 65){
  digitalWrite(3,HIGH);
  digitalWrite(4,LOW);
 }

  if (Enciende == 66){
  digitalWrite(5,HIGH);
  digitalWrite(6,LOW);
 }
  if (Enciende == 67){
  digitalWrite(7,HIGH);
  digitalWrite(8,LOW);
 }
  if (Enciende == 68){
  digitalWrite(9,HIGH);
  digitalWrite(10,LOW);
 }
  if (Enciende == 69){
  digitalWrite(11,HIGH);
  digitalWrite(12,LOW);
 }
  if (Enciende == 70){
  analogWrite(A0,250);
  analogWrite(A1,0);
 }
  if (Enciende == 71){
  analogWrite(A2,250);
  analogWrite(A3,0);
 }
  if (Enciende == 72){
  analogWrite(A4,250);
  analogWrite(A5,0);
 }
  if (Enciende == 73){
  analogWrite(A6,250);
  analogWrite(A7,0);
 }
 


//Instrucciones para invertir polaridad del anterior

if (Pieza==65){
 if (A == 65){
  digitalWrite(3,LOW);
  digitalWrite(4,HIGH);
 }

  if (A == 66){
  digitalWrite(5,LOW);
  digitalWrite(6,HIGH);
 }
  if (A == 67){
  digitalWrite(7,LOW);
  digitalWrite(8,HIGH);
 }
  if (A == 68){
  digitalWrite(9,LOW);
  digitalWrite(10,HIGH);
 }
  if (A == 69){
  digitalWrite(11,LOW);
  digitalWrite(12,HIGH);
 }
  if (A == 70){
  analogWrite(A0,0);
  analogWrite(A1,250);
 }
  if (A == 71){
  analogWrite(A2,0);
  analogWrite(A3,250);
 }
  if (A == 72){
  analogWrite(A4,0);
  analogWrite(A5,250);
 }
  if (A == 73){
  analogWrite(A6,0);
  analogWrite(A7,250);
 }

   A = Enciende;
}


if (Pieza==66){
 if (B == 65){
  digitalWrite(3,LOW);
  digitalWrite(4,HIGH);
 }

  if (B == 66){
  digitalWrite(5,LOW);
  digitalWrite(6,HIGH);
 }
  if (B == 67){
  digitalWrite(7,LOW);
  digitalWrite(8,HIGH);
 }
  if (B == 68){
  digitalWrite(9,LOW);
  digitalWrite(10,HIGH);
 }
  if (B == 69){
  digitalWrite(11,LOW);
  digitalWrite(12,HIGH);
 }
  if (B == 70){
  analogWrite(A0,0);
  analogWrite(A1,250);
 }
  if (B == 71){
  analogWrite(A2,0);
  analogWrite(A3,250);
 }
  if (B == 72){
  analogWrite(A4,0);
  analogWrite(A5,250);
 }
  if (B == 73){
  analogWrite(A6,0);
  analogWrite(A7,250);
 }

   B = Enciende;
}


if (Pieza==67){
 if (C == 65){
  digitalWrite(3,LOW);
  digitalWrite(4,HIGH);
 }

  if (C == 66){
  digitalWrite(5,LOW);
  digitalWrite(6,HIGH);
 }
  if (C == 67){
  digitalWrite(7,LOW);
  digitalWrite(8,HIGH);
 }
  if (C == 68){
  digitalWrite(9,LOW);
  digitalWrite(10,HIGH);
 }
  if (C == 69){
  digitalWrite(11,LOW);
  digitalWrite(12,HIGH);
 }
  if (C == 70){
  analogWrite(A0,0);
  analogWrite(A1,250);
 }
  if (C == 71){
  analogWrite(A2,0);
  analogWrite(A3,250);
 }
  if (C == 72){
  analogWrite(A4,0);
  analogWrite(A5,250);
 }
  if (C == 73){
  analogWrite(A6,0);
  analogWrite(A7,250);
 }

   C = Enciende;
}

  delay(750);
digitalWrite(3, LOW);
digitalWrite(4,LOW);
digitalWrite(5, LOW);
digitalWrite(6,LOW);
digitalWrite(7, LOW);
digitalWrite(8,LOW);
digitalWrite(9, LOW);
digitalWrite(10,LOW);
digitalWrite(11, LOW);
digitalWrite(12,LOW);
analogWrite(A0,0);
analogWrite(A1,0);
analogWrite(A2,0);
analogWrite(A3,0);
analogWrite(A4,0);
analogWrite(A5,0);
analogWrite(A6,0);
analogWrite(A7,0);
}





}


