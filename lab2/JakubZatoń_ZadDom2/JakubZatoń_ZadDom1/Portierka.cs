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
    public class Portierka : Kierowniczka
    {
        public Portierka()
        {

        }
        public Portierka(int lvl)
        {
            this.level = lvl;
        }
        public void Hello()
        {
            MessageBox.Show("Nie psuć krzeseł!");
        }
    }
}
