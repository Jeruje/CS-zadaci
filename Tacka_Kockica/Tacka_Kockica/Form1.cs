using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tacka_Kockica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] nizx = new int[6];
        int[] nizy = new int[6];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            nizx[i] = ClientRectangle.Width / 3;
                            nizy[i] = ClientRectangle.Height / 3;
                        }
                        break;
                    case 1: { nizx[i] = ClientRectangle.Width / 2; nizy[i] = ClientRectangle.Height / 3; } break;
                    case 2: { nizx[i] = ClientRectangle.Width * 2 / 3; nizy[i] = ClientRectangle.Height / 3; } break;
                    case 3: { nizx[i] = ClientRectangle.Width / 3; nizy[i] = ClientRectangle.Height * 2 / 3; } break;
                    case 4: { nizx[i] = ClientRectangle.Width / 2; nizy[i] = ClientRectangle.Height * 2 / 3; } break;
                    case 5: { nizx[i] = ClientRectangle.Width * 2 / 3; nizy[i] = ClientRectangle.Height * 2 / 3; } break;

                }

            }
        }
           

        
        Random n = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            Graphics g = CreateGraphics();
            
            for(int i =0;i<=5;i++)
            {

                Kockica k = new Kockica(nizx[i], nizy[i], 100, n.Next(6) + 1);
                k.Crtaj(g, n.Next(6) + 1, nizx[i], nizy[i], 100);
            }
                
            

        }
    }
}
