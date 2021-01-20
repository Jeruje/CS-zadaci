﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Smajli_A_B_C_D_
{
    class Smajli_A : Smajli
    {
        public Smajli_A(int x, int y) : base(x, y)
        {
        }

        public override void Crtaj(Graphics g)
        {

            Pen olovka = new Pen(Color.Black, 15);
            SolidBrush cetka1 = new SolidBrush(Color.Black);
            SolidBrush cetka2 = new SolidBrush(Color.Yellow);
            g.FillEllipse(cetka2, x - a / 2, y - a / 2, a, a);
            g.FillEllipse(cetka1, x - a / 5 - 15, y - 3 * a / 10, 30, 30);
            g.FillEllipse(cetka1, x + a / 5 - 15, y - 3 * a / 10, 30, 30);
            g.DrawArc(olovka, x - 3 * a / 10, y - 3 * a / 10, 120, 120, 0, 180);
        }
    }
}
