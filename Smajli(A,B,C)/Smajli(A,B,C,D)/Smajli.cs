using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Smajli_A_B_C_D_
{
    abstract class Smajli
    {
        protected int x, y, a = 200;
        public Smajli(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Crtaj(Graphics g);
    }
}
