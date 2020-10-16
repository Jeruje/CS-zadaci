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
namespace _16._10_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Takmicar[] t = new Takmicar[100];
        int n = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader f = new StreamReader("takmicari.txt");
                while(!f.EndOfStream)
                {
                    string takmicar = f.ReadLine();
                    int bodovi = Convert.ToInt32(f.ReadLine());
                    t[n] = new Takmicar(takmicar, bodovi);
                    listBox1.Items.Add(t[n].Prikaz());
                    n++;
                }
                
            }
            catch(Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i =0; i<n;i++)
            {
                for (int j = i+1;j<n;j++)
                {
                    if(t[i].Bolji(t[j]))
                    {
                        Takmicar p = t[i];
                        t[i] = t[j];
                        t[j] = p;
                    }
                }
            }
            listBox1.Items.Clear();
            for(int i =0;i<n;i++)
            {
                listBox1.Items.Add(t[i].Prikaz());
            }
            button1.Enabled = false;
        }
    }
}
