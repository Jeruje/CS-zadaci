using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Tacka_Kockica
{
    class Tacka
    {
        private int x, y;
        private Color boja;

        public Tacka(int x, int y)
        {
            if (x >= 0 && y >= 0)
            {
                this.x = x;
                this.y = y;
            }
            else
                throw new Exception("Koordinate su <0!");
        }

        public void PostaviBoju(Color boja)
        {
            this.boja = boja;
        }

        public void Crtaj(Graphics g)
        {
            SolidBrush cetka = new SolidBrush(boja);
            g.FillEllipse(cetka, x - 3, y - 3, 6, 6);
        }

    }
}
