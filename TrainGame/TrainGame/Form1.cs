using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainGame
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

        
        private void track2_CaughtOnFire(object sender, CaughtOnFireEventArgs e)
        {
            fire.Location = new System.Drawing.Point(track2.Left + e.Location, track2.Top - fire.Height);

            
        }
        //Metoda koja proverava da li se tacka C nalazi da duzi AB
        private int Tacka_na_duzi(int A, int B, int C)
        {
            if (C >= A && C <= B) return 1;
            else return 0;
        }
        //Metoda koja da li se vatra nalazi na vozu
        private void Fire_On_Train()
        {
            if ((Tacka_na_duzi(train3.Location.X - 32, train3.Location.X + 32, fire.Location.X - 24) == 1)
                || (Tacka_na_duzi(train3.Location.X - 32, train3.Location.X + 32, fire.Location.X + 24) == 1))
            {

                train3.ReStart();
                throttle.Value = 0;
                train3.Speed = 0;
                train3.Left = track2.Left;

                MessageBox.Show("Your train burned.");
                
            }
            
        }
        private void train3_DistanceChanged(object sender, DistanceChangedEventArgs e)
        {
            train3.Left = track2.Left + e.Distance;

            // Fire on Train
            Fire_On_Train();

            if (train3.Right >= track2.Right)
            {
                train3.Speed = 0;
                throttle.Value = 0;
                MessageBox.Show("You win");
            }
            
            
        }

        private void throttle_ValueChanged(object sender, EventArgs e)
        {
            if(train3.Right < track2.Right)
            {
                train3.Speed = throttle.Value;
            }
            else
            {
                throttle.Value = 0;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            train3.ReStart();
            throttle.Value = 0;
            train3.Speed = 0;
            train3.Left = track2.Left;
        }
    }
}
