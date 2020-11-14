namespace WindowsFormsMenus
{
    partial class TagModositas
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
            this.dataGridView_tagok = new System.Windows.Forms.DataGridView();
            this.textBox_orszag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_iranyitoszam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_rogzit = new System.Windows.Forms.Button();
            this.button_megsem = new System.Windows.Forms.Button();
            this.label_azonosito = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tagok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tag adatainak módosítása";
            // 
            // dataGridView_tagok
            // 
            this.dataGridView_tagok.AllowUserToAddRows = false;
            this.dataGridView_tagok.AllowUserToDeleteRows = false;
            this.dataGridView_tagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tagok.Location = new System.Drawing.Point(285, 9);
            this.dataGridView_tagok.Name = "dataGridView_tagok";
            this.dataGridView_tagok.ReadOnly = true;
            this.dataGridView_tagok.Size = new System.Drawing.Size(503, 429);
            this.dataGridView_tagok.TabIndex = 1;
            this.dataGridView_tagok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tagok_CellClick);
            // 
            // textBox_orszag
            // 
            this.textBox_orszag.Location = new System.Drawing.Point(99, 153);
            this.textBox_orszag.Name = "textBox_orszag";
            this.textBox_orszag.Size = new System.Drawing.Size(59, 20);
            this.textBox_orszag.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ország";
            // 
            // textBox_iranyitoszam
            // 
            this.textBox_iranyitoszam.Location = new System.Drawing.Point(99, 123);
            this.textBox_iranyitoszam.Name = "textBox_iranyitoszam";
            this.textBox_iranyitoszam.Size = new System.Drawing.Size(59, 20);
            this.textBox_iranyitoszam.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Irányítószám";
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Location = new System.Drawing.Point(99, 92);
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
            this.numericUpDown_szulev.TabIndex = 12;
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1930,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Születési év";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(62, 58);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(146, 20);
            this.textBox_nev.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Név";
            // 
            // button_rogzit
            // 
            this.button_rogzit.Location = new System.Drawing.Point(18, 195);
            this.button_rogzit.Name = "button_rogzit";
            this.button_rogzit.Size = new System.Drawing.Size(75, 23);
            this.button_rogzit.TabIndex = 17;
            this.button_rogzit.Text = "Rögzít";
            this.button_rogzit.UseVisualStyleBackColor = true;
            this.button_rogzit.Click += new System.EventHandler(this.button_rogzit_Click);
            // 
            // button_megsem
            // 
            this.button_megsem.Location = new System.Drawing.Point(149, 195);
            this.button_megsem.Name = "button_megsem";
            this.button_megsem.Size = new System.Drawing.Size(75, 23);
            this.button_megsem.TabIndex = 18;
            this.button_megsem.Text = "Mégsem";
            this.button_megsem.UseVisualStyleBackColor = true;
            this.button_megsem.Click += new System.EventHandler(this.button_megsem_Click);
            // 
            // label_azonosito
            // 
            this.label_azonosito.AutoSize = true;
            this.label_azonosito.Location = new System.Drawing.Point(90, 32);
            this.label_azonosito.Name = "label_azonosito";
            this.label_azonosito.Size = new System.Drawing.Size(0, 13);
            this.label_azonosito.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Azonosító";
            // 
            // TagModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_azonosito);
            this.Controls.Add(this.button_megsem);
            this.Controls.Add(this.button_rogzit);
            this.Controls.Add(this.textBox_orszag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_iranyitoszam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_szulev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_tagok);
            this.Controls.Add(this.label1);
            this.Name = "TagModositas";
            this.Text = "TagModositas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagModositas_FormClosing);
            this.Load += new System.EventHandler(this.TagModositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tagok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_tagok;
        private System.Windows.Forms.TextBox textBox_orszag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_iranyitoszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_rogzit;
        private System.Windows.Forms.Button button_megsem;
        private System.Windows.Forms.Label label_azonosito;
        private System.Windows.Forms.Label label7;
    }
}