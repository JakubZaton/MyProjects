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
        //przygotowanie do odpalenia muzyki
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
    
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
        //w tej funkcji się dzieje wszystko co sięzmienia na bieżąco
        private void timerStart_Tick(object sender, EventArgs e)
        {
            
            //zmiany w czasie danych
            counter++;
            stud++;

            //wyświetlanie ilości zasobów
            textBoxStud.Text = stud.ToString();
            textBoxAka.Text = aka.ToString();
            textBoxMoney.Text = money.ToString();
            textBoxChair.Text = chair.ToString();
            textBoxFood.Text = food.ToString();
            textBoxStatus.Text = status.ToString();

            //określanie ilości przychodów
            if (stud > 10)
                money = money + 10;

            if (stud < chair)
                money = money + 5;

            if (stud < food )
                money = money + 5;
            money = money + aka * 10;
            money = money + status * 10;
            //zdarzenia "losowe"
            if(counter%10==0)
            {
                MessageBox.Show("Studenci złamali krzesła!");
                chair = chair - 5;
            }
            if (counter%6==0)
            {
                food = food - 5;
            }
            if (counter%35==0)
            {
                MessageBox.Show("Pluskwy w pokoju, dezynsekcja koszztuje");
                money = money - 100;
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
            money = money - 100;
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            food = food + 50;
            money = money - 50;
        }

        private void buttonAka_Click(object sender, EventArgs e)
        {
            aka++;
            money = money - 1000;
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            status++;
            money = money - 5000;
        }
    }
}
