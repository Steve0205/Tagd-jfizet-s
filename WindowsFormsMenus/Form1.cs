using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.taguj.Show();
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagModositas.Show();
        }

        private void lekérdezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.lekerdezes.Show();
            
        }

        private void újToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ujbefizetes.Show();
        }
    }
}
