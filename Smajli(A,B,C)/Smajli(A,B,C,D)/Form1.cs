using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smajli_A_B_C_D_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
             
        private void Form1_Load(object sender, EventArgs e)
        {
             numericUpDown1.Maximum = 2;
        }

        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Graphics g = CreateGraphics();
            if (numericUpDown1.Value == 0)
            {
                Smajli_A s = new Smajli_A(x, y);
                s.Crtaj(g);
            }
            if (numericUpDown1.Value == 1)
            {
                Smajli_B s = new Smajli_B(x, y);
                s.Crtaj(g);
            }
            if (numericUpDown1.Value == 2)
            {
                Smajli_C s = new Smajli_C(x, y);
                s.Crtaj(g);
            }
        }
        


    }
}
