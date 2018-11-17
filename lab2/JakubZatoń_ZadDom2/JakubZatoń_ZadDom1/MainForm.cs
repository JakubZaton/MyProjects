using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubZatoń_ZadDom1
{
    public partial class MainForm : Form
    {
        //zmienne pocnicze do określania zasobów
        int counter=0;
        int stud = 0;
        int aka = 1;
        int money = 1;
        int chair = 50;
        int food = 100;
        int status = 0;
        //ilosc meneli
        int ilosc=0;
        //przechowywanie lvl kierowniczek
        int lvl=0;
        //stała ochraniająca przed zdarzeniami losowymi
        int protect=0;
        //przygotowanie do odpalenia muzyki
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //wielkość armii
        int Amount = 0;
    
    public MainForm()
        {
            InitializeComponent();
            //ścieżka do muzyki
            player.SoundLocation = "audio.wav";
        }

        //funkcja startująca liczenie czasu
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //odpalenie muzyki
            player.Play();
            //ustawienie interwału
            timerStart.Interval = 1000;
            //poczatek
            timerStart.Start();
            //funkcja zaczynająca działanie zegara

        }
        //funkcja ograniczająca zasoby
        private void Buying(int cash)
        {
            money = money - cash;
        }
        //w tej funkcji się dzieje wszystko co sięzmienia na bieżąco
        private void timerStart_Tick(object sender, EventArgs e)
        {
            
            //zmiany w czasie danych
            counter++;
            stud++;
            for (int i=0; i < ilosc; i++)
            {
                this.progressBarEnemy.Increment(1);
            }
            //Warunek wygrania gry

            if (progressBarEnemy.Value == 1000)
            {
                timerStart.Stop();
                MessageBox.Show("Wygrałeś!");
                Application.Exit();
            }
            textBoxAmount.Text = Amount.ToString();

            //wyświetlanie ilości zasobów
            textBoxStud.Text = stud.ToString();
            textBoxAka.Text = aka.ToString();
            textBoxMoney.Text = money.ToString();
            textBoxChair.Text = chair.ToString();
            textBoxFood.Text = food.ToString();
            textBoxStatus.Text = status.ToString();

            //określanie ilości przychodów
            if (stud > 10)
                money = money + 15;

            if (stud < chair)
                money = money + 10;

            if (stud < food )
                money = money + 10;
            //zarobki za akademik i lvl
            money = money + aka * 10*lvl;
            //zarobki za status
            money = money + status * 10;
            //zdarzenia "losowe"
            //kupienie kierowniczki wyłącza zdarzenie
            if(counter%10==0 && protect !=1)
            {
                MessageBox.Show("Studenci złamali krzesła!");
                chair = chair - 5;
            }
            if (counter%6==0)
            {
                food = food - 5;
            }
            //kupienie sprzataczki wyłącza zdarzenie
            if (counter%35==0 && protect != 2) 
            {
      
                MessageBox.Show("Pluskwy w pokoju, dezynsekcja koszztuje");
                money = money - 100;
            }
            //kupienie Portierki wyłącza zdarzenie
            if (counter%27 == 0 && protect != 3)
            {
                MessageBox.Show("Studenci zrobili impreze!");
                Buying(300);
                food = food - 20;

            }
            //warunek zakończenia gry
            if (money < 0)
            {
                timerStart.Stop();
                MessageBox.Show("Zbankrutowałeś!");
                Application.Exit();
                
            }

        }

        //upewnienie się czy na pewno chce się zakończyć aplikacę
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zakończyć aplikację?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
       
        //kupowanie budynków
        private void buttonChair_Click(object sender, EventArgs e)
        {
            chair = chair + 50;
            Buying(100);
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            food = food + 50;
            Buying(50);
        }

        private void buttonAka_Click(object sender, EventArgs e)
        {
            aka++;
            Buying(1000);
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            status++;
            Buying(5000);
        }
        /// <summary>
        /// Utworzenie klasy kierowniczki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKier_Click(object sender, EventArgs e)
        {
            Kierowniczka Kier = new Kierowniczka(lvl++);
            //Pozdrowienie
            Kier.Hello();
            //zapisanie lvl
            textBoxLevel.Text = Kier.level.ToString();
            //Określenie kto teraz jest szefem
            textBoxNameKier.Text = ("Kierowniczka");
            protect = 1;
            //Płacenie
            Buying(2000);
        }
        /// <summary>
        /// Utworzenie klasy Sprzataczki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSprzataczka_Click(object sender, EventArgs e)
        {
            Sprzataczka Cleaner = new Sprzataczka(lvl++);
            //Pozdrowienie
            Cleaner.Hello();
            //zapisanie lvl
            textBoxLevel.Text = Cleaner.level.ToString();
            //Określenie kto teraz jest szefem
            textBoxNameKier.Text = ("Sprzątaczka");
            protect = 2;
            //Płacenie
            Buying(2000);
        }
        /// <summary>
        /// Utworzenie klasy kierowniczki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPortierka_Click(object sender, EventArgs e)
        {
            Portierka Portress = new Portierka(lvl++);
            //Pozdrowienie
            Portress.Hello();
            //zapisanie lvl
            textBoxLevel.Text = Portress.level.ToString();
            //Określenie kto teraz jest szefem
            textBoxNameKier.Text = ("Portierka");
            protect = 3;
            //Płacenie
            Buying(2000);
        }
     ///tworzenie jednostek atakujacych
     ///

            //tworzenie menela
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            Bum menel = new Bum();
            menel.Hi();
            //zwiekszamy ilosc
            ilosc++;
            Buying(300);
            //zwiekszamy ilosc armii
            Amount = Amount + menel.ilosc;
            
        }
        //tworzenie buldożera
        private void buttonDemolish_Click(object sender, EventArgs e)
        {
            Demolisher demo = new Demolisher();
            demo.Hi();
            //zwiekszamy ilosc dzialajacych
            ilosc = ilosc + 3; ;
            Buying(900);
            //zwiekszamy wielokosc armii
            Amount = Amount + demo.ilosc;
        }
        //kupienie wygranej
        private void button1_Click(object sender, EventArgs e)
        {
            Buy akademik = new Buy();
            akademik.Hi();
            //zwiekszamy ilosc dzialajacych
            ilosc = ilosc + 1000; ;
            Buying(1000);
            //zwiekszamy wielokosc armii
            Amount = Amount + akademik.ilosc;
        }
    }
}
