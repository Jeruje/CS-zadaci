
namespace TrainGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.throttle = new System.Windows.Forms.TrackBar();
            this.fire = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.train3 = new TrainGame.Train();
            this.track2 = new TrainGame.Track();
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.SuspendLayout();
            // 
            // throttle
            // 
            this.throttle.LargeChange = 10;
            this.throttle.Location = new System.Drawing.Point(448, 264);
            this.throttle.Maximum = 50;
            this.throttle.Name = "throttle";
            this.throttle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.throttle.Size = new System.Drawing.Size(56, 131);
            this.throttle.SmallChange = 5;
            this.throttle.TabIndex = 5;
            this.throttle.TickFrequency = 10;
            this.throttle.ValueChanged += new System.EventHandler(this.throttle_ValueChanged);
            // 
            // fire
            // 
            this.fire.BackColor = System.Drawing.Color.Transparent;
            this.fire.Image = global::TrainGame.Properties.Resources.fire;
            this.fire.Location = new System.Drawing.Point(250, 168);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(48, 48);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fire.TabIndex = 2;
            this.fire.TabStop = false;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(555, 311);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(104, 31);
            this.reset.TabIndex = 7;
            this.reset.Text = "New Game";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // train3
            // 
            this.train3.BackColor = System.Drawing.Color.Transparent;
            this.train3.BackgroundImage = global::TrainGame.Properties.Resources.railroad__1_;
            this.train3.Location = new System.Drawing.Point(12, 168);
            this.train3.Name = "train3";
            this.train3.Size = new System.Drawing.Size(65, 65);
            this.train3.Speed = 0;
            this.train3.TabIndex = 6;
            this.train3.DistanceChanged += new TrainGame.Train.DistanceChangedEventHandler(this.train3_DistanceChanged);
            // 
            // track2
            // 
            this.track2.FireFrequency = 3;
            this.track2.Location = new System.Drawing.Point(0, 213);
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(708, 30);
            this.track2.TabIndex = 1;
            this.track2.CaughtOnFire += new TrainGame.Track.CaughtOnFireEventHandler(this.track2_CaughtOnFire);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 407);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.train3);
            this.Controls.Add(this.throttle);
            this.Controls.Add(this.track2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Track track2;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.TrackBar throttle;
        private Train train3;
        private System.Windows.Forms.Button reset;
    }
}

