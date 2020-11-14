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
    public partial class TagModositas : Form
    {
        public TagModositas()
        {
            InitializeComponent();

        }

        private void TagModositas_Load(object sender, EventArgs e)
        {
            dataGridView_tagok.ColumnCount = 6;
            dataGridView_tagok.Columns[0].Name = "azon";
            dataGridView_tagok.Columns[0].HeaderText = "Azonosító";
            dataGridView_tagok.Columns[1].Name = "nev";
            dataGridView_tagok.Columns[1].HeaderText = "Név";
            dataGridView_tagok.Columns[2].Name = "szulev";
            dataGridView_tagok.Columns[2].HeaderText = "Születési év";
            dataGridView_tagok.Columns[3].Name = "irszam";
            dataGridView_tagok.Columns[3].HeaderText = "Irányítószám"; 
            dataGridView_tagok.Columns[4].Name = "orsz";
            dataGridView_tagok.Columns[4].HeaderText = "Ország";
            try
            {
                Program.sql.CommandText = "SELECT * FROM `ugyfel` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_tagok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_tagok.Rows
                            [uj_sor_indexe];
                        uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["szulev"].Value = dr.GetString("szulev");
                        uj_sor.Cells["irszam"].Value = dr.GetString("irszam");
                        uj_sor.Cells["orsz"].Value = dr.GetString("orsz");
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

        private void TagModositas_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox_nev.Text = "";
            numericUpDown_szulev.Value = 1930;
            textBox_iranyitoszam.Text = "";
            textBox_orszag.Text = "";
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void dataGridView_tagok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sor = dataGridView_tagok.CurrentCell.RowIndex;
            label_azonosito.Text = dataGridView_tagok.Rows[sor].Cells[0].Value.ToString();
            textBox_nev.Text = dataGridView_tagok.Rows[sor].Cells[1].Value.ToString();
            numericUpDown_szulev.Value = int.Parse(dataGridView_tagok.Rows[sor].Cells[2].Value.ToString());
            textBox_iranyitoszam.Text = dataGridView_tagok.Rows[sor].Cells[3].Value.ToString();
            textBox_orszag.Text = dataGridView_tagok.Rows[sor].Cells[4].Value.ToString();

        }

        private void button_megsem_Click(object sender, EventArgs e)
        {
            textBox_nev.Text = "";
            numericUpDown_szulev.Value = 1930;
            textBox_iranyitoszam.Text = "";
            textBox_orszag.Text = "";
            label_azonosito.Text = "";
            this.Hide();
            Program.nyito.Show();
        }

        private void button_rogzit_Click(object sender, EventArgs e)
        {
            if (label_azonosito.Text == "")
            {
                MessageBox.Show("Nincs kiválasztva adat!");
            }
            else
            { 
                Program.sql.CommandText = "UPDATE `ugyfel` SET `nev`= '" + textBox_nev.Text + "',`szulev`= '" + numericUpDown_szulev.Value + "' , `irszam`= '" + textBox_iranyitoszam.Text + "',`orsz`= '" + textBox_orszag.Text + "' WHERE `azon` LIKE '" + label_azonosito.Text + "' ";
                Program.sql.ExecuteNonQuery();
                textBox_nev.Text = "";
                numericUpDown_szulev.Value = 1930;
                textBox_iranyitoszam.Text = "";
                textBox_orszag.Text = "";
                label_azonosito.Text = "";
                dataGridView_tagok.Rows.Clear();
                Program.sql.CommandText = "SELECT * FROM `ugyfel` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView_tagok.Rows.Add();
                        DataGridViewRow uj_sor = dataGridView_tagok.Rows
                            [uj_sor_indexe];
                        uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                        uj_sor.Cells["nev"].Value = dr.GetString("nev");
                        uj_sor.Cells["szulev"].Value = dr.GetString("szulev");
                        uj_sor.Cells["irszam"].Value = dr.GetString("irszam");
                        uj_sor.Cells["orsz"].Value = dr.GetString("orsz");
                    }
                }


            }
        }
    }
}
