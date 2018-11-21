#ifndef SCIEZKA_HH
#define SCIEZKA_HH

/*!
 * Plik zawiera definicję klasy Sciezka.
 */

#include "ObiektGraficzny.hh"

/*!
 * Klasa modeluje linię, czyli zbiór punktów które są łączone w programie \e gnuplot.
 */
class Sciezka : public ObiektGraficzny
{

public:

    /*!
     * \brief Inicjalizuje pierwszy punkt linii.
     */
    void DodajPierwszyPunkt(double a, double b, std::string g);

    /*!
     * \brief Metoda rysująca linię.
     */
    void RysujSciezke(Wektor2D pol, std::string g);
};

#endif
