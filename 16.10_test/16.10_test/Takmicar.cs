using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10_test
{
    class Takmicar
    {
        
        private string takmicar;
        private int bodovi;
        
        
        public Takmicar(string takmicar, int bodovi)
        {
            if (takmicar.Equals(string.Empty)) throw new Exception("Nema imena!");
            if (bodovi < 0) throw new Exception("Nema cene!");
            this.takmicar = takmicar;
            this.bodovi = bodovi;
        }
        

        
        public bool Bolji(Takmicar k)
        {
            if (bodovi < k.bodovi) return true;
            else return false;
        }
        public string Prikaz()
        {
            return takmicar + " - " + bodovi + " poena";
        }
        
    }
}
