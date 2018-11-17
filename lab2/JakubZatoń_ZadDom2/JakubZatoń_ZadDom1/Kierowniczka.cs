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
    /// <summary>
    /// klasa publiczna
    /// </summary>
    public class Kierowniczka
    {
        /// <summary>
        /// level kierowniczki
        /// </summary>
        public int level = 1;
        /// <summary>
        /// przywitanie się
        /// </summary>
        public Kierowniczka()
        {

        }
    public Kierowniczka(int lvl)
    {
        this.level = lvl;
    }
    public void Hello()
        {
            MessageBox.Show("Znowu ci studenci!");
        }
    }
}
