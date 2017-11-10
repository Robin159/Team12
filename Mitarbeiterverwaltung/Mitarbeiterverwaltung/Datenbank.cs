using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mitarbeiterverwaltung
{
    public partial class Datenbank : Form
    {
        public Datenbank()
        {
            InitializeComponent();
        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Datenbank_Load(object sender, EventArgs e)
        {
            /*try
            {
                Anlegen.con.Open(); // open connection
                SqlCommand cmd = new SqlCommand("USE Mitarbeiter;", Anlegen.con); // use database
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT * FROM t_mitarbeiter;"; // select datarows
                cmd.ExecuteNonQuery();

                DataTable t = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(t);

                dataGridView1.DataSource = t;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Anlegen.con.Close(); // close connection
            */
        }
    }
}
