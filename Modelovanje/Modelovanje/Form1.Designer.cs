namespace Modelovanje
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
            this.tbProizvod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNovaCena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCena2 = new System.Windows.Forms.TextBox();
            this.tbProizvodjac2 = new System.Windows.Forms.TextBox();
            this.tbNaziv2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPoruka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbProizvod
            // 
            this.tbProizvod.Location = new System.Drawing.Point(47, 35);
            this.tbProizvod.Name = "tbProizvod";
            this.tbProizvod.Size = new System.Drawing.Size(310, 22);
            this.tbProizvod.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbNovaCena);
            this.groupBox1.Location = new System.Drawing.Point(47, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova cena";
            // 
            // tbNovaCena
            // 
            this.tbNovaCena.Location = new System.Drawing.Point(22, 31);
            this.tbNovaCena.Name = "tbNovaCena";
            this.tbNovaCena.Size = new System.Drawing.Size(134, 22);
            this.tbNovaCena.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Promeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPoruka);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbNaziv2);
            this.groupBox2.Controls.Add(this.tbProizvodjac2);
            this.groupBox2.Controls.Add(this.tbCena2);
            this.groupBox2.Location = new System.Drawing.Point(47, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drugi proizvod";
            // 
            // tbCena2
            // 
            this.tbCena2.Location = new System.Drawing.Point(137, 100);
            this.tbCena2.Name = "tbCena2";
            this.tbCena2.Size = new System.Drawing.Size(139, 22);
            this.tbCena2.TabIndex = 0;
            // 
            // tbProizvodjac2
            // 
            this.tbProizvodjac2.Location = new System.Drawing.Point(137, 72);
            this.tbProizvodjac2.Name = "tbProizvodjac2";
            this.tbProizvodjac2.Size = new System.Drawing.Size(139, 22);
            this.tbProizvodjac2.TabIndex = 1;
            // 
            // tbNaziv2
            // 
            this.tbNaziv2.Location = new System.Drawing.Point(137, 44);
            this.tbNaziv2.Name = "tbNaziv2";
            this.tbNaziv2.Size = new System.Drawing.Size(139, 22);
            this.tbNaziv2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Koji proizvod je skuplji?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPoruka
            // 
            this.tbPoruka.Location = new System.Drawing.Point(155, 184);
            this.tbPoruka.Name = "tbPoruka";
            this.tbPoruka.Size = new System.Drawing.Size(100, 22);
            this.tbPoruka.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proizvodjac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cena";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbProizvod);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProizvod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNovaCena;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPoruka;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbNaziv2;
        private System.Windows.Forms.TextBox tbProizvodjac2;
        private System.Windows.Forms.TextBox tbCena2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

