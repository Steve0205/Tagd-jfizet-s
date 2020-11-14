namespace WindowsFormsMenus
{
    partial class Lekerdezes
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
            this.dataGridView_befizetesek = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_befizetesek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_befizetesek
            // 
            this.dataGridView_befizetesek.AllowUserToAddRows = false;
            this.dataGridView_befizetesek.AllowUserToDeleteRows = false;
            this.dataGridView_befizetesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_befizetesek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_befizetesek.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_befizetesek.Name = "dataGridView_befizetesek";
            this.dataGridView_befizetesek.ReadOnly = true;
            this.dataGridView_befizetesek.Size = new System.Drawing.Size(632, 316);
            this.dataGridView_befizetesek.TabIndex = 0;
            // 
            // Lekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 316);
            this.Controls.Add(this.dataGridView_befizetesek);
            this.Name = "Lekerdezes";
            this.Text = "Lekerdezes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lekerdezes_FormClosing);
            this.Load += new System.EventHandler(this.Lekerdezes_Load);
            this.VisibleChanged += new System.EventHandler(this.Lekerdezes_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_befizetesek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_befizetesek;
    }
}