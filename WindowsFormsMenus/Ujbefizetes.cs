using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsMenus
{
    public partial class Ujbefizetes : Form
    {
        public Ujbefizetes()
        {
            InitializeComponent();
        }

        private void ujbefizetes_Load(object sender, EventArgs e)
        {
            try
            {
                Program.sql.CommandText = "SELECT * FROM `ugyfel` WHERE 1";
                
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        comboBox_ugyfel.Items.Add(dr.GetString("nev")+", "+ dr.GetString("azon") + ", " + dr.GetString("szulev") +", " + dr.GetString("irszam") + ", " + dr.GetString("orsz"));
                        
                    }

                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }
            
        }

        private void comboBox_ugyfel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sor = comboBox_ugyfel.SelectedIndex;
            string[] adat = comboBox_ugyfel.Text.Split(',');
            label_nev.Text = adat[0];
            label_azon.Text = adat[1];
            label_szulev.Text = adat[2];
            label_irszam.Text = adat[3];
            label_orszag.Text = adat[4];
        }

        private void Ujbefizetes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button_rogzit_Click(object sender, EventArgs e)
        {
            if(textBox_osszeg.Text=="")
            {
                MessageBox.Show("Nincs beírva összeg!", "Hibás adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label_azon.Text=="")
            {
                MessageBox.Show("Nincs kiválasztva senki!", "Hibás adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    label7.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    Program.sql.CommandText = "INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES('" + label_azon.Text + "', '" + label7.Text + "', '" + textBox_osszeg.Text + "')";
                    
                    Program.sql.ExecuteNonQuery();
                    textBox_osszeg.Text = "";
                    label_azon.Text = "";
                    label_irszam.Text = "";
                    label_nev.Text = "";
                    label_orszag.Text = "";
                    label_szulev.Text = "";
                    comboBox_ugyfel.Text = "";
                }
                catch (MySqlException myex)
                {
                    MessageBox.Show(myex.Message);
                    Environment.Exit(0);
                    throw;
                }
            }
        }

        private void textBox_osszeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Csak számot írhatsz be!", "Hibás adat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_megsem_Click(object sender, EventArgs e)
        {
            textBox_osszeg.Text = "";
            label_azon.Text = "";
            label_irszam.Text = "";
            label_nev.Text = "";
            label_orszag.Text = "";
            label_szulev.Text = "";
            comboBox_ugyfel.Text="";
            this.Hide();
            Program.nyito.Show();

        }
    }
}
