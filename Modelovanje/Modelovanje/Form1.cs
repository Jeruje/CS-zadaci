﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Modelovanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Proizvod[] p = new Proizvod[100];
        int n = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader f = new StreamReader("Proizvodi.txt");
                while(!f.EndOfStream)
                {
                    string naziv = f.ReadLine();
                    string proizvodjac = f.ReadLine();
                    int cena = Convert.ToInt32(f.ReadLine());
                    p[n] =new Proizvod( naziv, proizvodjac, cena);
                    listBox1.Items.Add(p[n].Prikaz());
                    n++;
                }
                f.Close();
            }
            catch(Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (p[i].Skuplji(p[j]))
                    {
                        Proizvod t = p[i];
                        p[i] = p[j];
                        p[j] = t;
                    }
                }
            }
            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(p[i].Prikaz());
            }

            button1.Enabled = false;
        }
    }
}

