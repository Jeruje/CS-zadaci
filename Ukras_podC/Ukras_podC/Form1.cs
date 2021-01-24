using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukras_podC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Pocetak
        Ukras u;
        Random r = new Random();
        int k, l, x, y;
        private void Form1_Load(object sender, EventArgs e)
        {
            k = ClientRectangle.Width;
            l = ClientRectangle.Height;
            
            
               
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            x = r.Next(100, k - 100);
            y = r.Next(100, l - 100);
            Color b1 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            Color b2 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            Color b3 = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            u = new Ukras(x, y, r.Next(20, 70), b1, b2, b3);
            u.Crtaj(g);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
               
        }
    }
}
