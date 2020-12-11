using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Tacka_Kockica
{
    class Kockica
    {
        private int x, y, a = 100, n;
        private Color boja = Color.Black;

        public Kockica(int x, int y, int a, int n)
        {
            if (x >= 50 && y >= 50)
            {
                this.x = x;
                this.y = y;
                this.n = n;
            }
            else
                throw new Exception("Kockica bi izasla!");
        }

        public void Crtaj(Graphics g, int n, int x, int y, int a, int i)
        {
            
            Point t1 = new Point(x - a / 2, y - a / 2);
            Point t2 = new Point(x + a / 2, y - a / 2);
            Point t3 = new Point(x + a / 2, y + a / 2);
            Point t4 = new Point(x - a / 2, y + a / 2);

            Pen olovka = new Pen(Color.Black);
            Point[] temena = { t1, t2, t3, t4 };
            g.DrawPolygon(olovka, temena);

            if (n % 2 == 1)
            {
                Tacka p1 = new Tacka(x, y);
                p1.PostaviBoju(Color.Black,i);
                p1.Crtaj(g);
            }
            if (n > 1)
            {
                Tacka p2 = new Tacka(x - a / 4, y - a / 4);
                p2.PostaviBoju(Color.Black,i);
                p2.Crtaj(g);
                Tacka p3 = new Tacka(x + a / 4, y + a / 4);
                p3.PostaviBoju(Color.Black,i);
                p3.Crtaj(g);
            }
            if (n >= 4)
            {
                Tacka p4 = new Tacka(x + a / 4, y - a / 4);
                p4.PostaviBoju(Color.Black,i);
                p4.Crtaj(g);
                Tacka p5 = new Tacka(x - a / 4, y + a / 4);
                p5.PostaviBoju(Color.Black,i);
                p5.Crtaj(g);
            }
                if (n == 6)
                {
                    Tacka p6 = new Tacka(x - a / 4, y);
                    p6.PostaviBoju(Color.Black,i);
                    p6.Crtaj(g);
                    Tacka p7 = new Tacka(x + a / 4, y);
                    p7.PostaviBoju(Color.Black,i);
                    p7.Crtaj(g);
                }
            
        }

    }
}
