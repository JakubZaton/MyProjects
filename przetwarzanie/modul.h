
#define MAX 512            /* Maksymalny rozmiar wczytywanego obrazu */
#define DL_LINII 1024

int czytaj(FILE *plik_we,int obraz_pgm[][MAX],int *wymx,int *wymy, int *szarosci);

void wyswietl(char *n_pliku);

int zapisz(FILE *plik,int obraz_pgm[][MAX],int *wymx,int *wymy, int *szarosci);

void progowaniec( int obraz_pgm[][MAX], int wymx, int wymy, int szarosci, int poziomp);

void rozmyciepion( int obraz_pgm[][MAX], int wymx, int wymy, int radius);

void rozciaganieh( int obraz_pgm[][MAX], int wymx, int wymy, int *szarosci);

