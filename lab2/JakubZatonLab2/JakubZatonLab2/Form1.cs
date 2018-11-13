using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Do zadanie domowego, hermetyzacja wszytskiego
//zadanie domowe dopisac Zad1 do tego jak ten się nazywa
//do programu które wykonaliśmy który zrobiliśmy wcześniej, za surowce trzeba zrobić 3 jednostki defensywne(zabezpiecza przed atakami) i 3 ofensywne jako klasy (zmniejszyc innym)6 klas
//dziedzziczenie fajne by bylo
//progressBar mile widziane
// StreamReader StreamWriter - Save Game można zrobić

namespace JakubZatonLab2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// wlasciwosc - definicja listy koni
        /// </summary>
        public List<Horse> HorseList { get; set; }
        public Form1()
        {
            InitializeComponent();
            //tworzenie zdefiniowanej listy
            HorseList = new List<Horse>();
        }

        private void labelFav_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Dodanie nowego konia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddHorse_Click(object sender, EventArgs e)
        {
            //tworzenie obiketu "kon" na podstawie danych, ktore wprowadzamy do textboxow
            Horse newHorse = GetHorseData();
            //dodanie konia do listy
            HorseList.Add(newHorse);

        }

        /// <summary>
        /// Tworzenie jednorozca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddUnicorn_Click(object sender, EventArgs e)
        {
            //obiket "kon na podstawie danych, obiekt zostanie stworzony w getdata i zwrocony do zmiennej lokalnej "newHorse"
            Horse horse = GetHorseData();
            //pobieranie wartosci z texboxu i przypisywanie do pola w obiekcie

            //tworzenie obiektu jednorozca na podstawie obiektu  "horse"
            Unicorn unicorn = new Unicorn(horse);

            //pobieranie wartosci z textboxa
            unicorn.CornColor = textBoxCornColor.Text;

            //dodanie jednorozca do listy koni
            HorseList.Add(unicorn);
            HorseList.Add(horse);
        }

        private Horse GetHorseData()
        {
            //Wczytywanie textboxow i tworzenia konia na jego podstawie
            //Zwraca obiket typu horse
            #region tworzenie konia
            Horse newHorse = new Horse();
            //przypisywanie wartosci do wlasciwosci Name
            newHorse.Name = "Jack";
            newHorse.Name = textBoxHorseName.Text;
            //przypisywanie wartosci do wlasciwosci FavouriteNumber
            newHorse.FavouriteNumber = 69;
            newHorse.FavouriteNumber = int.Parse(textBoxFavNumber.Text);
            #endregion
            //dodanie konia do listy
            return newHorse;
        }
    }
}
