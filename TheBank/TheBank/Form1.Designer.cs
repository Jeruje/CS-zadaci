
namespace TheBank
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.ComboBox();
            this.action = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submit = new System.Windows.Forms.Button();
            this.addInterest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // account
            // 
            this.account.FormattingEnabled = true;
            this.account.Location = new System.Drawing.Point(225, 70);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(238, 24);
            this.account.TabIndex = 1;
            this.account.SelectedIndexChanged += new System.EventHandler(this.account_SelectedIndexChanged);
            // 
            // action
            // 
            this.action.FormattingEnabled = true;
            this.action.Location = new System.Drawing.Point(225, 118);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(238, 24);
            this.action.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Action";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(225, 168);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(238, 22);
            this.amount.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(114, 271);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(102, 31);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // addInterest
            // 
            this.addInterest.Location = new System.Drawing.Point(296, 271);
            this.addInterest.Name = "addInterest";
            this.addInterest.Size = new System.Drawing.Size(105, 31);
            this.addInterest.TabIndex = 7;
            this.addInterest.Text = "Add";
            this.addInterest.UseVisualStyleBackColor = true;
            this.addInterest.Click += new System.EventHandler(this.addInterest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transaction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addInterest);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.action);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox account;
        private System.Windows.Forms.ComboBox action;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button addInterest;
        private System.Windows.Forms.Label label3;
    }
}

