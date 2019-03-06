using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace RestoApp
{
    public partial class Main : Form
    {
        public Main(string nom)
        {
            InitializeComponent();
            lblBienvenue.Text += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nom.ToLower());//Permet d'avoir un message d'accueil personnalisé
        }
        // Accueil
        private void lklblAccueil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tcChoix.SelectedIndex = 0;
            lklblAccueil.Enabled = false;
            lklblEntree.Enabled = true;
            lklblPlat.Enabled = true;
            lklblDessert.Enabled = true;
            lklblBoisson.Enabled = true;
        }
        // Entree
        private void lklblEntree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tcChoix.SelectedIndex = 1;
            lklblAccueil.Enabled = true;
            lklblEntree.Enabled = false;
            lklblPlat.Enabled = true;
            lklblDessert.Enabled = true;
            lklblBoisson.Enabled = true;
        }

        //plat
        private void lklblPlat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tcChoix.SelectedIndex = 2;
            lklblAccueil.Enabled = true;
            lklblEntree.Enabled = true;
            lklblPlat.Enabled = false;
            lklblDessert.Enabled = true;
            lklblBoisson.Enabled = true;
        }

        //Dessert
        private void lklblDessert_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tcChoix.SelectedIndex = 3;
            lklblAccueil.Enabled = true;
            lklblEntree.Enabled = true;
            lklblPlat.Enabled = true;
            lklblDessert.Enabled = false;
            lklblBoisson.Enabled = true;
        }

        //Boisson
        private void lklblBoisson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tcChoix.SelectedIndex = 4;
            lklblAccueil.Enabled = true;
            lklblEntree.Enabled = true;
            lklblPlat.Enabled = true;
            lklblDessert.Enabled = true;
            lklblBoisson.Enabled = false;
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            string connexionString = "server=localhost;user=root;database=restoapp;persistsecurityinfo=True;port=3306;password=;SslMode=none";
            MySqlConnection conn = new MySqlConnection(connexionString);
            try
            {
                conn.Open();
                string requete = "SELECT detailConso, prixConso FROM consommations WHERE id_type=1";
                MySqlCommand command = new MySqlCommand(requete, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    lbEntree.Items.Add(reader.GetString(0) + " - " + reader.GetFloat(1) + "€");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                string requete = "SELECT detailConso, prixConso FROM consommations WHERE id_type=2";
                MySqlCommand command = new MySqlCommand(requete, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbPlat.Items.Add(reader.GetString(0) + " - " + reader.GetFloat(1) + "€");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                string requete = "SELECT detailConso, prixConso FROM consommations WHERE id_type=3";
                MySqlCommand command = new MySqlCommand(requete, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbDessert.Items.Add(reader.GetString(0) + " - " + reader.GetFloat(1) + "€");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                string requete = "SELECT detailConso, prixConso FROM consommations WHERE id_type=4";
                MySqlCommand command = new MySqlCommand(requete, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbBoisson.Items.Add(reader.GetString(0) + " - " + reader.GetFloat(1) + "€");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        
    }
}
