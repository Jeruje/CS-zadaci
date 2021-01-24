﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ukras_podC
{
    class Ukras
    {
        int x, y, a;
        Color boja1, boja2, boja3;

        public Ukras(int x, int y, int a, Color boja1, Color boja2, Color boja3)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            this.boja1 = boja1;
            this.boja2 = boja2;
            this.boja3 = boja3;
        }

        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(boja1);
            SolidBrush cetka = new SolidBrush(boja2);
            g.FillEllipse(cetka, x - a, y - a, 2 * a, 2 * a);
            cetka.Color = boja3;
            g.FillRectangle(cetka, x - a / 6, y - (7 * a) / 6, a / 3, a / 6);
            g.DrawEllipse(olovka, x - a / 3, y - (13 * a) / 6, (2 * a) / 3, a);
        }

    }
}
