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
    public partial class Anlegen : Form
    {
        public Anlegen()
        {
            InitializeComponent();
        }

        // public static SqlConnection con = new SqlConnection("server = (localdb)\\MSSQLLocalDB; Integrated Security = sspi;"); // sql connection

        private void Anlegen_Load(object sender, EventArgs e)
        {
            /*SqlCommand cmd = new SqlCommand("CREATE DATABASE Mitarbeiter;", con);
            try
            {
                con.Open(); // open connection
                // create database
                cmd.ExecuteNonQuery();

                // MessageBox.Show("Die Datenbank Lottospiel wurde erfolgreich erstellt!");
            }
            catch (SqlException ex)
            {

            }

            try
            {
                cmd.CommandText = "USE Mitarbeiter;"; // use database
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE t_mitarbeiter" + " (ID primary key auto_increment not null, Titel Varchar(40), Vorname VARCHAR(40), Nachname VARCHAR(40), Straße Varchar(100), PLZ Varchar(20), Ort Varchar(40), Land Varchar(40), Firmentelefon Varchar(40), Email Varchar(40), Firmensitz Varchar(40), Abteilung Varchar(40), Eingestellt_am(Date), Monatsgehalt decimal(2), Gehaltsklasse Varchar(20), Kontostand decimal(2));"; // create table
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close(); // close connection
            }
        }
        /* Button
          try
            {
                con.Open(); // open connection
                SqlCommand cmd = new SqlCommand("USE Mitarbeiter;", con); // use database
                cmd.ExecuteNonQuery();


               
                

                for (int i = 0; i < lst_zahlenwahl.Items.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO t_mitarbeiter (ID, Titel, Vorname, Nachname, Straße, PLZ, Ort, Land, Firmentelefon, Email, Firmensitz, Abteilung, Eingestellt_am, Monatsgehalt, Gehaltsklasse, Kontostand) VALUES('" + txt_id.Text + "', '" + txt_titel.Text + "', '" + txt_vorname.Text + "', '" + txt_nachname.Text + "', '" + txt_straße.Text + "', '" + "', '" + txt_plz.Text + "', '" + txt_ort.Text + "', '" + txt_land.Text + "', '" + txt_firmentelefon.Text + + "', '" + txt_email.Text + "', '" + txt_firmensitz.Text + "', '" + txt_abteilung.Text + txt_eingestellt.Text + + "', '" + txt_monatsgehalt.Text + "', '" + txt_gehaltsklasse.Text + "', '" + txt_kontostand.Text + "');"; // add datarows
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); // close connection
            } 
         */
        }
        private void txt_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void txt_first_name_Enter(object sender, EventArgs e)
        {
            if (txt_first_name.Text == txt_first_name.Tag.ToString())        
            {

                txt_first_name.Text = "";
                txt_first_name.ForeColor = Color.Black;
            }
        }
        private void txt_first_name_leave(object sender, EventArgs e)
        {
            if (txt_first_name.Text.Trim() == "")
            {
                txt_first_name.Text = txt_first_name.Tag.ToString();
                txt_first_name.ForeColor = Color.Silver;              
            }
        }




        private void txt_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void txt_surname_Enter(object sender, EventArgs e)
        {
            if (txt_surname.Text == txt_surname.Tag.ToString())
            {

                txt_surname.Text = "";
                txt_surname.ForeColor = Color.Black;
            }
        }
        private void txt_surname_leave(object sender, EventArgs e)
        {
            if (txt_surname.Text.Trim() == "")
            {
                txt_surname.Text = txt_surname.Tag.ToString();
                txt_surname.ForeColor = Color.Silver;
            }
        }

    }
}
