using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrviPismeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 500 ;
            int y = 400;
            k = new Kap(x, y);
            
            Width = 1000;
            Height = 800;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        Kap k;
        private void timer1_Tick(object sender, EventArgs e)
        {
            k.Pomeri(2);
            Refresh();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
           
            Graphics g = CreateGraphics();
            SolidBrush cetka = new SolidBrush(Color.White);
            g.FillRectangle(cetka, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            
            k.Crtaj(g);
            cetka.Color = Color.Purple;
            g.FillRectangle(cetka, ClientRectangle.Width / 2 - 40, ClientRectangle.Height - 100, 80, 100);
            g.FillRectangle(cetka, ClientRectangle.Width / 2 - 20, ClientRectangle.Height - 120, 40, 20);
        }
    }
}
