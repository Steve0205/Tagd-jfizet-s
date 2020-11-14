namespace WindowsFormsMenus
{
    partial class Ujbefizetes
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
            this.comboBox_ugyfel = new System.Windows.Forms.ComboBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.label_azon = new System.Windows.Forms.Label();
            this.label_szulev = new System.Windows.Forms.Label();
            this.label_irszam = new System.Windows.Forms.Label();
            this.label_orszag = new System.Windows.Forms.Label();
            this.groupBox_adatok = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_osszeg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_rogzit = new System.Windows.Forms.Button();
            this.button_megsem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_adatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_ugyfel
            // 
            this.comboBox_ugyfel.FormattingEnabled = true;
            this.comboBox_ugyfel.Location = new System.Drawing.Point(38, 34);
            this.comboBox_ugyfel.Name = "comboBox_ugyfel";
            this.comboBox_ugyfel.Size = new System.Drawing.Size(204, 21);
            this.comboBox_ugyfel.Sorted = true;
            this.comboBox_ugyfel.TabIndex = 0;
            this.comboBox_ugyfel.SelectedIndexChanged += new System.EventHandler(this.comboBox_ugyfel_SelectedIndexChanged);
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(94, 59);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(0, 13);
            this.label_nev.TabIndex = 1;
            // 
            // label_azon
            // 
            this.label_azon.AutoSize = true;
            this.label_azon.Location = new System.Drawing.Point(94, 29);
            this.label_azon.Name = "label_azon";
            this.label_azon.Size = new System.Drawing.Size(0, 13);
            this.label_azon.TabIndex = 2;
            // 
            // label_szulev
            // 
            this.label_szulev.AutoSize = true;
            this.label_szulev.Location = new System.Drawing.Point(94, 89);
            this.label_szulev.Name = "label_szulev";
            this.label_szulev.Size = new System.Drawing.Size(0, 13);
            this.label_szulev.TabIndex = 3;
            // 
            // label_irszam
            // 
            this.label_irszam.AutoSize = true;
            this.label_irszam.Location = new System.Drawing.Point(94, 118);
            this.label_irszam.Name = "label_irszam";
            this.label_irszam.Size = new System.Drawing.Size(0, 13);
            this.label_irszam.TabIndex = 4;
            // 
            // label_orszag
            // 
            this.label_orszag.AutoSize = true;
            this.label_orszag.Location = new System.Drawing.Point(94, 146);
            this.label_orszag.Name = "label_orszag";
            this.label_orszag.Size = new System.Drawing.Size(0, 13);
            this.label_orszag.TabIndex = 5;
            // 
            // groupBox_adatok
            // 
            this.groupBox_adatok.Controls.Add(this.label5);
            this.groupBox_adatok.Controls.Add(this.label4);
            this.groupBox_adatok.Controls.Add(this.label3);
            this.groupBox_adatok.Controls.Add(this.label2);
            this.groupBox_adatok.Controls.Add(this.label1);
            this.groupBox_adatok.Controls.Add(this.label_nev);
            this.groupBox_adatok.Controls.Add(this.label_orszag);
            this.groupBox_adatok.Controls.Add(this.label_azon);
            this.groupBox_adatok.Controls.Add(this.label_irszam);
            this.groupBox_adatok.Controls.Add(this.label_szulev);
            this.groupBox_adatok.Location = new System.Drawing.Point(38, 89);
            this.groupBox_adatok.Name = "groupBox_adatok";
            this.groupBox_adatok.Size = new System.Drawing.Size(193, 192);
            this.groupBox_adatok.TabIndex = 6;
            this.groupBox_adatok.TabStop = false;
            this.groupBox_adatok.Text = "Adatok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ország";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Irányítószám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Születési év";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Név";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Azonosító";
            // 
            // textBox_osszeg
            // 
            this.textBox_osszeg.Location = new System.Drawing.Point(390, 34);
            this.textBox_osszeg.Name = "textBox_osszeg";
            this.textBox_osszeg.Size = new System.Drawing.Size(109, 20);
            this.textBox_osszeg.TabIndex = 7;
            this.textBox_osszeg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_osszeg_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Befizetett összeg";
            // 
            // button_rogzit
            // 
            this.button_rogzit.Location = new System.Drawing.Point(300, 89);
            this.button_rogzit.Name = "button_rogzit";
            this.button_rogzit.Size = new System.Drawing.Size(75, 23);
            this.button_rogzit.TabIndex = 9;
            this.button_rogzit.Text = "Rögzít";
            this.button_rogzit.UseVisualStyleBackColor = true;
            this.button_rogzit.Click += new System.EventHandler(this.button_rogzit_Click);
            // 
            // button_megsem
            // 
            this.button_megsem.Location = new System.Drawing.Point(424, 89);
            this.button_megsem.Name = "button_megsem";
            this.button_megsem.Size = new System.Drawing.Size(75, 23);
            this.button_megsem.TabIndex = 10;
            this.button_megsem.Text = "Mégsem";
            this.button_megsem.UseVisualStyleBackColor = true;
            this.button_megsem.Click += new System.EventHandler(this.button_megsem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Ujbefizetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 305);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_megsem);
            this.Controls.Add(this.button_rogzit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_osszeg);
            this.Controls.Add(this.groupBox_adatok);
            this.Controls.Add(this.comboBox_ugyfel);
            this.Name = "Ujbefizetes";
            this.Text = "Új befizetés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ujbefizetes_FormClosing);
            this.Load += new System.EventHandler(this.ujbefizetes_Load);
            this.groupBox_adatok.ResumeLayout(false);
            this.groupBox_adatok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ugyfel;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_azon;
        private System.Windows.Forms.Label label_szulev;
        private System.Windows.Forms.Label label_irszam;
        private System.Windows.Forms.Label label_orszag;
        private System.Windows.Forms.GroupBox groupBox_adatok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_osszeg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_rogzit;
        private System.Windows.Forms.Button button_megsem;
        private System.Windows.Forms.Label label7;
    }
}