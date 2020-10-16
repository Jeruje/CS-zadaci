using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Aplikacija_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
        int x, y;
        int r = 50;
        SolidBrush cetka = new SolidBrush(Color.Green);
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            g.FillEllipse(cetka, x, y, r, r);
            y += 3;
            if (ClientRectangle.Height - r < y) timer1.Stop();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            timer1.Start();
        }

    }
}
