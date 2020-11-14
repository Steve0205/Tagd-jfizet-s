using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsMenus
{
    public partial class Taguj : Form
    {
        public Taguj()
        {
            InitializeComponent();
            

        }

        private void Taguj_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button_rogzit_Click(object sender, EventArgs e)
        {
            Program.sql.CommandText = "INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES ('null','" +textBox_nev.Text+ "','" +numericUpDown_szulev.Value+ "','" + textBox_iranyitoszam.Text+ "','" + textBox_orszag.Text+ "')";
            try
            {
                Program.sql.ExecuteNonQuery();
                textBox_nev.Text = "";
                numericUpDown_szulev.Value = 1930;
                textBox_iranyitoszam.Text = "";
                textBox_orszag.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("A rögzítés sikertelen!\n\n" + ex.Message);
                    return;
            }
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox_nev.Text = "";
            numericUpDown_szulev.Value = 1930;
            textBox_iranyitoszam.Text = "";
            textBox_orszag.Text = "";
            Program.nyito.Show();
        }
    }
}
