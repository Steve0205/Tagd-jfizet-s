﻿namespace WindowsFormsMenus
{
    partial class Taguj
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
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_iranyitoszam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_orszag = new System.Windows.Forms.TextBox();
            this.button_rogzit = new System.Windows.Forms.Button();
            this.button_kilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új tag felvétele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(69, 61);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(146, 20);
            this.textBox_nev.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Születési év";
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Location = new System.Drawing.Point(106, 95);
            this.numericUpDown_szulev.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown_szulev.Minimum = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            this.numericUpDown_szulev.Name = "numericUpDown_szulev";
            this.numericUpDown_szulev.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_szulev.TabIndex = 4;
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Irányítószám";
            // 
            // textBox_iranyitoszam
            // 
            this.textBox_iranyitoszam.Location = new System.Drawing.Point(106, 126);
            this.textBox_iranyitoszam.Name = "textBox_iranyitoszam";
            this.textBox_iranyitoszam.Size = new System.Drawing.Size(59, 20);
            this.textBox_iranyitoszam.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ország";
            // 
            // textBox_orszag
            // 
            this.textBox_orszag.Location = new System.Drawing.Point(106, 156);
            this.textBox_orszag.Name = "textBox_orszag";
            this.textBox_orszag.Size = new System.Drawing.Size(59, 20);
            this.textBox_orszag.TabIndex = 8;
            // 
            // button_rogzit
            // 
            this.button_rogzit.Location = new System.Drawing.Point(39, 197);
            this.button_rogzit.Name = "button_rogzit";
            this.button_rogzit.Size = new System.Drawing.Size(75, 23);
            this.button_rogzit.TabIndex = 9;
            this.button_rogzit.Text = "Rögzít";
            this.button_rogzit.UseVisualStyleBackColor = true;
            this.button_rogzit.Click += new System.EventHandler(this.button_rogzit_Click);
            // 
            // button_kilepes
            // 
            this.button_kilepes.Location = new System.Drawing.Point(131, 197);
            this.button_kilepes.Name = "button_kilepes";
            this.button_kilepes.Size = new System.Drawing.Size(75, 23);
            this.button_kilepes.TabIndex = 10;
            this.button_kilepes.Text = "Kilépés";
            this.button_kilepes.UseVisualStyleBackColor = true;
            this.button_kilepes.Click += new System.EventHandler(this.button_kilepes_Click);
            // 
            // Taguj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 252);
            this.Controls.Add(this.button_kilepes);
            this.Controls.Add(this.button_rogzit);
            this.Controls.Add(this.textBox_orszag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_iranyitoszam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_szulev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Taguj";
            this.Text = "Taguj";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Taguj_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_iranyitoszam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_orszag;
        private System.Windows.Forms.Button button_rogzit;
        private System.Windows.Forms.Button button_kilepes;
    }
}