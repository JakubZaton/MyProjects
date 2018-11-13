using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubZatonLab2
{
    /// <summary>
    /// Klasa jednorozec 
    /// </summary>
    class Unicorn : Horse
    {
        /// <summary>
        /// wlasciwosc - kolor rogu
        /// </summary>
        public string CornColor { get; set; }
        /// <summary>
        /// konstruktor bezparametryczny
        /// </summary>
        public Unicorn()
        {
                
        }

        /// <summary>
        /// konstruktor paramteryczny, dziedziczacy po horse
        /// </summary>
        /// <param name="horse"></param>
        public Unicorn(Horse horse)
        {
            //przypisanie nazwy
            this.Name = horse.Name;
            //przypisuje liczbe
            this.FavouriteNumber = horse.FavouriteNumber;
            

        }
    }
}
