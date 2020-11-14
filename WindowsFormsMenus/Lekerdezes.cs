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
    public partial class Lekerdezes : Form
    {
        public Lekerdezes()
        {
            InitializeComponent();
        }

        private void Lekerdezes_Load(object sender, EventArgs e)
        {
            dataGridView_befizetesek.ColumnCount = 3;
            dataGridView_befizetesek.Columns[0].Name = "azon";
            dataGridView_befizetesek.Columns[0].HeaderText = "Azonosító";
            dataGridView_befizetesek.Columns[1].Name = "datum";
            dataGridView_befizetesek.Columns[1].HeaderText = "Dátum";
            dataGridView_befizetesek.Columns[2].Name = "osszeg";
            dataGridView_befizetesek.Columns[2].HeaderText = "Összeg";
        }

        private void Lekerdezes_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            
            e.Cancel = true;
            Program.nyito.Show();
            

        }

        private void Lekerdezes_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                dataGridView_befizetesek.Rows.Clear();
                try
                {

                    Program.sql.CommandText = "SELECT * FROM `befiz` WHERE 1";
                    using (MySqlDataReader dr = Program.sql.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int uj_sor_indexe = dataGridView_befizetesek.Rows.Add();
                            DataGridViewRow uj_sor = dataGridView_befizetesek.Rows
                                [uj_sor_indexe];
                            uj_sor.Cells["azon"].Value = dr.GetInt32("azon");
                            uj_sor.Cells["datum"].Value = dr.GetString("datum");
                            uj_sor.Cells["osszeg"].Value = dr.GetString("osszeg") + " Ft";
                        }
                    }

                    dataGridView_befizetesek.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView_befizetesek.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView_befizetesek.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dataGridView_befizetesek.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView_befizetesek.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                }
                catch (MySqlException myex)
                {
                    MessageBox.Show(myex.Message);
                    Environment.Exit(0);
                    throw;
                }
            }
        }
    }
}

