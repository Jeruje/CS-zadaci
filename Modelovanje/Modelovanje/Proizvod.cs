using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelovanje
{
    class Proizvod
    {
        #region atributi
        private string naziv, proizvodjac;
        private int cena;
        #endregion
        
       #region konstruktori
        public Proizvod(string naziv, string proizvodjac, int cena)
        {
            if (naziv.Equals(string.Empty)) throw new Exception("Nije unet naziv!");
            if (proizvodjac.Equals(string.Empty)) throw new Exception("Nije unet proizvodjac!");
            if (cena<0) throw new Exception("Cena je manja od nule!");
            this.naziv = naziv;
            this.proizvodjac = proizvodjac;
            this.cena = cena;
        }
        #endregion

        #region metode
        public bool Skuplji(Proizvod p)
        {
            if (cena > p.cena) return true;
            else return false;
        }
       
        public string  Prikaz()
        {
            return naziv + ", " + proizvodjac + " - " + cena + " RSD";
        }
        #endregion

    }
}
