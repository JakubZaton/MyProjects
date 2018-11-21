#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<math.h>
/************************************************************************************
 * Jakub Zatoñ       	       	       	       	                                    *
 *Wykonane: 06.12.2017								    *
 *Numer indeksu: 241504 			                                    *
 *Program przetwarzajacy wybrany plik .pgm i zapisujacy go pod dowolna nazwa 	    *
 *						                                    *
 ************************************************************************************/

#define MAX 512            /* Maksymalny rozmiar wczytywanego obrazu */
#define DL_LINII 1024      /* Dlugosc buforow pomocniczych */

/************************************************************************************
 * Funkcja wczytuje obraz PGM z pliku do tablicy       	       	       	       	    *
 *										    *
 * \param[in] plik_we uchwyt do pliku z obrazem w formacie PGM			    *
 * \param[out] obraz_pgm tablica, do ktorej zostanie zapisany obraz		    *
 * \param[out] wymx szerokosc obrazka						    *
 * \param[out] wymy wysokosc obrazka						    *
 * \param[out] szarosci liczba odcieni szarosci					    *
 * \return liczba wczytanych pikseli						    *
 ************************************************************************************/

int czytaj(FILE *plik_we,int obraz_pgm[][MAX],int *wymx,int *wymy, int *szarosci) {
  char buf[DL_LINII];      /* bufor pomocniczy do czytania naglowka i komentarzy */
  int znak;                /* zmienna pomocnicza do czytania komentarzy */
  int koniec=0;            /* czy napotkano koniec danych w pliku */
  int i,j;

  /*Sprawdzenie czy podano prawid³owy uchwyt pliku */
  if (plik_we==NULL) {
    fprintf(stderr,"Blad: Nie podano uchwytu do pliku\n");
    return(0);
  }

  /* Sprawdzenie "numeru magicznego" - powinien byæ P2 */
  if (fgets(buf,DL_LINII,plik_we)==NULL)   /* Wczytanie pierwszej linii pliku do bufora */
    koniec=1;                              /* Nie udalo sie? Koniec danych! */

  if ( (buf[0]!='P') || (buf[1]!='2') || koniec) {  /* Czy jest magiczne "P2"? */
    fprintf(stderr,"Blad: To nie jest plik PGM\n");
    return(0);
  }

  /* Pominiecie komentarzy */
  do {
    if ((znak=fgetc(plik_we))=='#') {         /* Czy linia rozpoczyna sie od znaku '#'? */
      if (fgets(buf,DL_LINII,plik_we)==NULL)  /* Przeczytaj ja do bufora                */
	koniec=1;                   /* Zapamietaj ewentualny koniec danych */
    }  else {
      ungetc(znak,plik_we);                   /* Gdy przeczytany znak z poczatku linii */
    }                                         /* nie jest '#' zwroc go                 */
  } while (znak=='#' && !koniec);   /* Powtarzaj dopoki sa linie komentarza */
                                    /* i nie nastapil koniec danych         */

  /* Pobranie wymiarow obrazu i liczby odcieni szarosci */
  if (fscanf(plik_we,"%d %d %d",wymx,wymy,szarosci)!=3) {
    fprintf(stderr,"Blad: Brak wymiarow obrazu lub liczby stopni szarosci\n");
    return(0);
  }
  /* Pobranie obrazu i zapisanie w tablicy obraz_pgm*/
  for (i=0;i<*wymy;i++) {
    for (j=0;j<*wymx;j++) {
      if (fscanf(plik_we,"%d",&(obraz_pgm[i][j]))!=1) {
	fprintf(stderr,"Blad: Niewlasciwe wymiary obrazu\n");
	return(0);
      }
    }
  }
  return *wymx**wymy;   /* Czytanie zakonczone sukcesem    */
}                       /* Zwroc liczbe wczytanych pikseli */


/* Wyswietlenie obrazu o zadanej nazwie za pomoca programu "display"   */
  void wyswietl(char *n_pliku) {
  char polecenie[DL_LINII];      /* bufor pomocniczy do zestawienia polecenia */

  strcpy(polecenie,"display ");  /* konstrukcja polecenia postaci */
  strcat(polecenie,n_pliku);     /* display "nazwa_pliku" &       */
  strcat(polecenie," &");
  printf("%s\n",polecenie);      /* wydruk kontrolny polecenia */
  system(polecenie);             /* wykonanie polecenia        */
}
int zapisz(FILE *plik,int obraz_pgm[][MAX],int *wymx,int *wymy, int *szarosci) //Fukcja zapisujaca do wybranego pliku
{
  int  pixel=0; //zmienna pomocnicza
  int cnt =0; //zmienna dzieki ktorej "ladniej sie zapisuje"
  int x; //zmienne dzieki ktorym mozna latwo sie przemieszcac po tablicy
  int  y;
  fprintf(plik,"P2\n%d %d\n%d\n",*wymx,*wymy,*szarosci); //zapisywanie "magicznej liczby"
  for(y=0;y<*wymy;y++)   //koljene zmienianie wartosci tablicy dwuwymiarowej
    {                 
      for(x=0;x<*wymx;x++)
	{
	  pixel=obraz_pgm[y][x];
	  fprintf(plik,"%3d ",pixel);
	  if(pixel < 10)               //warunki "uladniajace" zapis
	     	fprintf(plik, "  ");

			if((pixel > 9) && (pixel < 100))
				fprintf(plik, " ");
	cnt += 4;

			if(cnt > 67)
			{
				fprintf(plik,"\n");
				cnt = 0;
			}
	}
    }
  return 0;
}
void progowaniec( int obraz_pgm[][MAX], int wymx, int wymy, int szarosci, int poziomp) //Funkcja progujaca czerni
{
	int x, y;

	for(y=0; y < wymy; y++)
		for(x=0; x < wymx; x++)
		  if(obraz_pgm[y][x] <=poziomp)  //warunek matematyczny dzialania funkcji
				obraz_pgm[y][x] = 0;
}
void rozmyciepion( int obraz_pgm[][MAX], int wymx, int wymy, int radius)  //funkcja rozmywajaca pionowo
{
  int x, y,yp,ym;
  int obrazL[MAX][MAX];  //tablica rozwiajujaca problem wczytywania argumentow spoza tablicy podstawowej

	for(x=0; x < wymx; x++)
	  for(y=0; y < wymy; y++){
	    obrazL[y][x]=obraz_pgm[y][x];     //zapisywanie tablicy do tablicy pomocnicznej
	    ym=y-radius;
	    if(ym<0)ym=0;      //sprawadznie czy nie wczytuje spoza tablicy
		  yp=y+radius;
		  if(yp>MAX)yp=MAX;
		  obraz_pgm[y][x] = (obrazL[ym][x] + obraz_pgm[y][x] + obraz_pgm[yp][x])/3 ; //warunek matemtyczny dzialnai funckji
	  }
}
void rozciaganieh( int obraz_pgm[][MAX], int wymx, int wymy, int *szarosci) //funckja rozciagajaca histogram
{
  int x, y; //zmienne do "chodzenia" po tablicy
  int min=255; //zmienna do sprawdzania minimum
  int max=0; //zmienna do sprawdzania maksimum
  *szarosci=255; //zmienienie zakresu obrazu
  for(y=0; y< wymy; y++)
    {
      for(x=0; x< wymx; x++)  //sprawdzanie minimum i maksimum w tablicy
	{
	  if(obraz_pgm[y][x]<min)
	    min=obraz_pgm[x][y];
	  if(obraz_pgm[y][x]>max)
	    max=obraz_pgm[y][x];
	}
    }
 for(y=0; y< wymy; y++)
    {
      for(x=0; x< wymx; x++)
	{
	  obraz_pgm[y][x]=(obraz_pgm[y][x]-min)*(255/(max-min)); //warunek matematyczny dzialnia funckji
	}
    }
} 

int main() {
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

 /*  /* Wczytanie zawartosci wskazanego pliku do pamieci     PROTOTYP PROGRAMU
  printf("Podaj nazwe pliku:\n");
  scanf("%s",nazwa);
  plik=fopen(nazwa,"r");

  if (plik != NULL) {       /* co spowoduje zakomentowanie tego warunku 
    odczytano = czytaj(plik,obraz,&wymx,&wymy,&odcieni);
  }
  /* Wyswietlenie poprawnie wczytanego obraza zewnetrznym programem 
  if (odczytano != 0)
    wyswietl(nazwa);
  /*Zapisywanie pliku 
 poziomp=122;
 int radius=1;
 rozciaganieh(plik,obraz,&wymx,&wymy,&odcieni);
 fclose(plik);
    wyswietl(nazwa);

printf("Podaj nazwe pliku do zapisu:\n");
scanf("%s",nazwa_wy);

 plik=fopen(nazwa_wy,"w");
 zapisz(plik,obraz,&wymx,&wymy,&odcieni);
 fclose(plik);
 wyswietl(nazwa_wy); */
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
/*        Sprawozdanie
Przed uruchumieniem programu nalezy go skompilowac(najlepiej: gcc -o odczyt odczyt.c
Uruchamianie programu to komenda: ./odczyt
Testy:
1.Uruchamiam program i wczytuje obrazek, wyswietlam obrazek odpowenia komenda. Program dziala odpowiednio.
2.Uruchamiam program, wczytuje obraz, zmieniam obraz uzywajac funkcji np. rozymcie pionwe, wyswietlam obraz i obraz jest poprawnie przetworzony.
3.Uruchamiam program, wczytuje obraz, przetwarzam go a nastepni zaposuje przetworzony obraz. Program dziala odpowiednio.
4.Uruchamiam program i wczytuje obrazek a nastepni wybieram opcje z menu niedozwolym znakiem np. 'a', program dziala nieprawidlowo
Wnioski:
Nalezy pamietac zeby po kazdym otwarcia pliku fopen, nalezy go zamknac fclose.
W jednej z funkcji (rozmycie pionowe) nalezy pamietac zeby nie wczytywac argumenty spoza tablicy.
Wazne zeby program byl w tym samym katalogu co obrazki, bo inaczej program bedzie mial problem z wczytwaniem tych obrazow
Program nie posiada zabezpieczen na niepoprawne wpisywane danych/formatow
Warto pisac dokumentacje i komentarze
*/

