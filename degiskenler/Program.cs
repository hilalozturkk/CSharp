using System;

namespace degiskenler
{
class Program
{
public static void Main(string[] args)
{
int deger = 2;
string degisken = null;
string Degisken = null; //değişken tanımlamaları büyük küçük harf duyarlıdır
// int 3degisken hatalı kullanım bir değişken ismi sayı ile başlayamaz
// string class gibi özel isimler değişken ismi olamaz

// string degisken+veri = null değişken isminde operatörler kullanılamaz
string degisken_veri = null;

//DEĞİŞKEN TİPLERİ :

string degisken1 = " ";

byte b = 5; //bellekte 1 byte yer kaplar
sbyte c = 5; //1 byte

short s = 5; //2 byte 
ushort us = 5; //2 byte

Int16 i16 = 2; //2 byte
int i = 2; //4 byte
Int32 i32 = 2; //4 byte
Int64 i64 = 2; //8 byte 

uint ui = 2; //4 byte 
long l = 4; //8 byte
ulong ul = 4; //8 byte

//REEL SAYILAR : 
float f = 5; //4 byte 
double d = 5; //8 byte
decimal de = 5;//16 byte

char ch = '3'; //2 byte
string str = "Hilal"; //sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now; //şuanda tarih ve saat 

Console.WriteLine(dt);
//her türlü veriyi object türüne atayabiliyoruz 
object o1 = "x" ; 
object o2 = 'y' ;
object o3 = 4 ;
object o4 = 4.3 ; 
//string ifadeler
string str1 = string.Empty; 
str1 = "hilal öztürk";
string ad = "hilal";
string soyad = "öztürk";
string tamAd = ad + soyad ; 
//integer tanımlama şekillleri

int int1 = 5;
int int2 = 4;
int int3 = int1*int2 ;//20 

//boolen 

bool bool1 = 20<2; //false 

//Değişken dönüşümleri
string str20 = "20";
int int20 = 20;

//string şekliyle birleştirmek
string yenideger = str20 + int20.ToString();// çıktı :2020 
Console.WriteLine(yenideger);

//int şekliyle birleştirmek
int int21 = int20 + Convert.ToInt32(str20);//çıktı :40
Console.WriteLine(int21);

//diğer int şekline çevirme
int int22 = int20 + int.Parse(str20); //çıktı 40
Console.WriteLine(int22);

// datetime

string datetime = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);
}
}
}