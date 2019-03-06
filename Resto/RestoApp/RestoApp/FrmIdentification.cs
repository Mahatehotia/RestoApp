using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace RestoApp
{
    public partial class FrmIdentification : Form
    {
        public FrmIdentification()
        {
            InitializeComponent();
        }

        private void btnIdentifier_Click(object sender, EventArgs e)
        {
            //Instanciation de la chaine de connexion
            string connexionString = "server=localhost;user=root;database=restoapp;persistsecurityinfo=True;port=3306;password=;SslMode=none";
            MySqlConnection conn = new MySqlConnection(connexionString);//Implémentation d'un objet de type MySqlConnection
            try
            {
                conn.Open();//Ouverture de la connexion
                string requete = "INSERT INTO clients (nomClient) VALUES (@nom)";
                MySqlCommand command = new MySqlCommand(requete, conn);//Implémentation d'un objet de type MySqlCommand
                command.Parameters.AddWithValue("@nom", tbxNom.Text);//Ajout de la valeur de la textBox au paramètre @nom
                command.ExecuteNonQuery();//Execution de cette requête
                Main m = new Main(tbxNom.Text);//Ouverture d'une nouvelle fenêtre
                m.ShowDialog();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);//Si l'insert se passe mal on renvoie un message d'erreur
            }
        }

        private void FrmIdentification_Load(object sender, EventArgs e) => btnIdentifier.Enabled = false;//Désactivation du bouton au démarrage

        private void btnClose_Click(object sender, EventArgs e) => this.Close();//Fermeture de la fenêtre si on appuie sur la X

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {
            if(tbxNom.TextLength == 0)
            {
                btnIdentifier.Enabled = false;//Désactive le bouton si aucun identifiant n'est rentré
            }
            else
            {
                btnIdentifier.Enabled = true;//Active sinon
            }
        }
    }
}
