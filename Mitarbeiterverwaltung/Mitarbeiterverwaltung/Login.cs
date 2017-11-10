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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_passwort.PasswordChar = '*';  //Hier wird festgelegt, dass das "*" im Vordergund ist und die normalen Buchstaben verborgen werden 
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ende l = new Ende();
            l.Show();        //Regstrierungsformular wird angezeigt
            this.Show();
            this.Activate();
            Application.DoEvents();
            System.Threading.Thread.Sleep(0);
            this.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl_fehler.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            string sql;
            // SqlCommand cmd;
            Int32 count;

            // Verbindungsobjekt wird erstellt
            SqlConnection con = new SqlConnection(Properties.Settings.Default.MitarbeiterConnectionString);

            // Verbindung zur Datenbank wird geöffnet
            con.Open();

            SqlCommand cmd = new SqlCommand("CREATE DATABASE Mitarbeiter;", con);
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

            //Der Variable sql wird das Select-Kommando zugewiesen
            sql = "Select Count(*) from Table where Benutzer = '" + txt_benutzername.Text + "' and Passwort = '" + txt_passwort.Text + "';";

            cmd = new SqlCommand(sql, con);             //Neues Kommandoobjekt mit der Variable sql und der Verbindung Con wird erzeugt
            count = (Int32)cmd.ExecuteScalar();         //Das Kommando wird nun ausgeführt, in der Variable count wird das Ergebnis gespeichert(0 oder 1)
            con.Close();                                //Verbindung wird wieder geschlossen

            //Prüfung, ob Benutzername und Passwort in der Datenbank gefunden wurden
            if (count == 1)       //Passwort und Benutzer stimmen überein
            {

                //Hier werden die Globalen Variablen festgelegt!! Ist sehr wichtig!!! Auf diese Variablen kann ich von allen Forms zugreifen!!!
                Globals.Benutzer = txt_benutzername.Text;


                con.Open();
                sql = "SELECT ID FROM Table where Benutzer = '" + txt_benutzername.Text + "'";        //der Variable sql wird erzeugt!! Es soll die ID von dem angemeldeten Benutzer verwendet werden.
                cmd = new SqlCommand(sql, con);

                Globals.BenutzerID = Convert.ToInt16(cmd.ExecuteScalar());
                con.Close();
                this.Hide();
                Datenbank d = new Datenbank();
                d.Show();
            }     
            else
            {
                lbl_fehler.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Anlegen a = new Anlegen();
            a.Show();
            this.Hide();

        }
    }

}
