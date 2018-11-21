#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<math.h>
#include "modul.h"
int czytaj(FILE *plik_we,int obraz_pgm[][MAX],int *wymx,int *wymy, int *szarosci) {
  char buf[DL_LINII];      /* bufor pomocniczy do czytania naglowka i komentarzy */
  int znak;                /* zmienna pomocnicza do czytania komentarzy */
  int koniec=0;            /* czy napotkano koniec danych w pliku */
  int i,j;

  /*Sprawdzenie czy podano prawidłowy uchwyt pliku */
  if (plik_we==NULL) {
    fprintf(stderr,"Blad: Nie podano uchwytu do pliku\n");
    return(0);
  }

  /* Sprawdzenie "numeru magicznego" - powinien być P2 */
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
