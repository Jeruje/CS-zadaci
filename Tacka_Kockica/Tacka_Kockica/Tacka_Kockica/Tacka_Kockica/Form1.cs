using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tacka_Kockica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] nizx = new int[7];
        int[] nizy = new int[7];
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                switch (i)
                {
                    case 1: { nizx[i] = ClientRectangle.Width / 3; nizy[i] = ClientRectangle.Height / 3; } break;
                    case 2: { nizx[i] = ClientRectangle.Width / 2; nizy[i] = ClientRectangle.Height / 3;  } break;
                    case 3: { nizx[i] = ClientRectangle.Width * 2 / 3; nizy[i] = ClientRectangle.Height / 3; } break;
                    case 4: { nizx[i] = ClientRectangle.Width / 3; nizy[i] = ClientRectangle.Height * 2 / 3; } break;
                    case 5: { nizx[i] = ClientRectangle.Width / 2; nizy[i] = ClientRectangle.Height * 2 / 3; } break;
                    case 6: { nizx[i] = ClientRectangle.Width * 2 / 3; nizy[i] = ClientRectangle.Height * 2 / 3; } break;

                }

            }
        }
           

        
        Random n = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            Graphics g = CreateGraphics();

            for (int i = 1; i <= 6; i++)
            {
                Kockica k = new Kockica(nizx[i], nizy[i], 100, n.Next(6) + 1);
                k.Crtaj(g, n.Next(6) + 1, nizx[i], nizy[i], 100, i);
            }



        }
    }
}

