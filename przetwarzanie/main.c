#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<math.h>
#include"modul.h"
#define MAX 512            /* Maksymalny rozmiar wczytywanego obrazu */
#define DL_LINII 1024



int main(int argc, char *argv[]) {
  int obraz[MAX][MAX] ;  //tablica wczytujaca obraz
  int wymx,wymy,odcieni; //podstawowe zmienne opisujace obraz
  int odczytano = 0; //zmienna potrzebna do prototypu
  FILE *plik; //deklaracja pliku
  FILE *plik_wy; //jak wyzej
  char nazwa[100]; //tablica na nazwe wejscia
  char nazwa_wy[100]; //tablica na nazwe wyjscia
  int poziomp=0; //zmienna do potrzebna do funkcji
  int radius=0; //jak wyzej
  char wybor[2]=" "; //zmienna pomocnicza w dzilaniu menu


printf("Witaj w programie do przetwarzanie obrazow!\n");
 do //petla do wylaczanie programu
   {
     printf("1-odczyt\n2-przetwarzanie polprogowe czerni\n3-rozmycie pionowe\n4-rozciaganie histogramu\n5-wyswietl plik\n6-zapisz plik\n7-koniec");
     scanf("%1s",wybor); //wczytywanie wyboru
     switch(wybor[0]) //wybor dzialnia
  {
  case '1': //wczytywanie pliku
  {
 printf("Podaj nazwe pliku:\n");
 scanf("%s",nazwa); //wczytywanie nazy pliku ktory chcemy wczytac
  plik=fopen(nazwa,"r"); //otwieranie strumienia
  if (plik != NULL) 
    {       /* co spowoduje zakomentowanie tego warunku */
      odczytano = czytaj(plik,obraz,&wymx,&wymy,&odcieni);
      fclose(plik); //zamykanie strumienia
    }
    break;
    };
  case '2': //progowanie czerni
     {
       printf("Podaj wartosc progowania(proponuje 122): ");
       scanf("%d",&poziomp);  //ustawenie poziomu progowania czerni
       progowaniec(obraz,wymx,wymy,odcieni,poziomp);
       break;
     };
  case '3': //rozmycie pionowe
     {
       printf("Podaj wartosc promienia: ");
       scanf("%d",&radius); //ustawianie poziomu rozmycia
       rozmyciepion(obraz,wymx,wymy,radius);
       break;
     };
  case '4': //rozciaganie histogramu
     {
       rozciaganieh(obraz,wymx,wymy,&odcieni);
       break;
     };
  case '5': //zapisywanie pliku 
    {
      plik_wy=fopen("a","w"); //otwieranie strumienia i nazwa deafaultowa "a"
 zapisz(plik_wy,obraz,&wymx,&wymy,&odcieni); //wczytywanie adresow poniewaz zmieniaja sie te zmienne
 fclose(plik_wy);
 wyswietl("a");
 break;
    };
   case '6':
     {
       printf("Podaj nazwe pliku do zapisu:\n"); //wczytywanie nazwy do zapisania
scanf("%s",&nazwa_wy);
 plik_wy=fopen(nazwa_wy,"w"); //otwieranie strumienia
 zapisz(plik_wy,obraz,&wymx,&wymy,&odcieni);
 fclose(plik_wy);
 wyswietl(nazwa_wy); //wyswietla zapisany plik
 break;
     };
  }
   }while(wybor[0]!='7'); //argument dla ktorego program przestaje dzialac
}
