using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrviPismeni
{
    class Kap
    {
        int x, y;
        int a=10;
        
        public Kap(int x, int y)
        {
            this.x = x;
            this.y = y;
          
        }

        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(Color.Aqua, 4);
            SolidBrush cetkap = new SolidBrush(Color.Aqua);
            SolidBrush cetkab = new SolidBrush(Color.White);
            g.DrawEllipse(olovka, x - a, y - a, 2 * a, 2 * a);
            g.FillEllipse(cetkap, x - a, y - a, 2 * a, 2 * a);
            g.FillRectangle(cetkab, x - a - 10, y - a, 2 * a + 20, a);
            Point p1 = new Point(x, y - 2 * a);
            Point p2 = new Point(x - a, y);
            Point p3 = new Point(x + a, y);
            Point[] niz = { p1, p2, p3 };
            g.FillPolygon(cetkap, niz);
        }

        public void Pomeri(int dy)
        {
            y += dy;
        }

    }
}
