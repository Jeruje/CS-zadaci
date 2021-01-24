using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukras_podA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ukras u;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 400;
            int y = 500;
            u = new Ukras(x, y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Color b1 = Color.FromArgb( r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            Color b2 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            Color b3 = Color.FromArgb( r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            u.Crtaj(e.X, e.Y, g, r.Next(20, 200), b1, b2, b3);
        }
    }
}
