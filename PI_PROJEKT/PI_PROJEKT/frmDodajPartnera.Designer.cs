﻿namespace PI_PROJEKT
{
    partial class frmDodajPartnera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtZiroRacun = new System.Windows.Forms.TextBox();
            this.txtTelefonskiBroj = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Žiro račun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonski broj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(103, 6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(169, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtZiroRacun
            // 
            this.txtZiroRacun.Location = new System.Drawing.Point(103, 49);
            this.txtZiroRacun.Name = "txtZiroRacun";
            this.txtZiroRacun.Size = new System.Drawing.Size(169, 20);
            this.txtZiroRacun.TabIndex = 5;
            this.txtZiroRacun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZiroRacun_KeyPress);
            // 
            // txtTelefonskiBroj
            // 
            this.txtTelefonskiBroj.Location = new System.Drawing.Point(103, 92);
            this.txtTelefonskiBroj.Name = "txtTelefonskiBroj";
            this.txtTelefonskiBroj.Size = new System.Drawing.Size(169, 20);
            this.txtTelefonskiBroj.TabIndex = 6;
            this.txtTelefonskiBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonskiBroj_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 171);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(257, 34);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj poslovnog partnera";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmDodajPartnera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefonskiBroj);
            this.Controls.Add(this.txtZiroRacun);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajPartnera";
            this.Text = "DodajPartnera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDodajPartnera_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtZiroRacun;
        private System.Windows.Forms.TextBox txtTelefonskiBroj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDodaj;
    }
}