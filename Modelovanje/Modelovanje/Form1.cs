using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelovanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Proizvod p;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string naziv = tbNaziv2.Text;
                string proizvodjac = tbProizvodjac2.Text;
                double cena = Convert.ToDouble(tbCena2.Text);
                Proizvod p2 = new Proizvod(naziv, proizvodjac, cena);

                if (p.SkupljiOd(p2))
                    tbPoruka.Text = "Skuplji je prvi";
                else if (p2.SkupljiOd(p))
                    tbPoruka.Text = "Skuplji je drugi";
                else tbPoruka.Text = "Kostaju isto";
            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Text = "Test aplikacija";

                p = new Proizvod("Kifla", "Pekara Ljupce");
                tbProizvod.Text = p.Prikaz();
                tbProizvod.ReadOnly = true;
            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double novaCena = Convert.ToDouble(tbNovaCena.Text);
                p.PromeniCenu(novaCena);
                tbProizvod.Text = p.Prikaz();
            }
            catch (Exception izuzetak)
            {
                MessageBox.Show(izuzetak.Message);
            }

        }
    }
}

