using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Connexion : Form
    {
        private dbStockContext db;
        //Classe connexion
        BL.CLS_Connexion C = new BL.CLS_Connexion();

        public FRM_Connexion()
        {
            InitializeComponent();
            // Initialiser la base de données
            db = new dbStockContext();
        }

        // pour vérifier les champs obligatoires
        string testObligatoire()
        {
            //si le nom d'utilisateur est vide ou le texte "Nom d'utilisateur" est affiché
            if (textNom.Text.Length == 0 || textNom.Text.Equals("Nom d'utilisateur"))
            {
                return "Entrer votre nom";
            }
            //si le mot de passe est vide ou le texte "Mot de passe" est affiché
            if (textMdp.Text.Length == 0 || textMdp.Text.Equals("Mot de passe"))
            {
                return "Entrer votre mot de passe";
            }
            return null;
        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitterConnx_Click(object sender, EventArgs e)
        {
            //uitter le formulaire
            this.Close();
        }

        private void textNom_Enter(object sender, EventArgs e)
        {
            //Pour vider le textVox
            if (textNom.Text.Equals("Nom d'utilisateur"))
            {
                textNom.Text = "";
                textNom.ForeColor = Color.WhiteSmoke; // changer la couleur du texte
            }
        }

        private void textMdp_Enter(object sender, EventArgs e)
        {
            //Pour vider le textVox
            if (textMdp.Text.Equals("Mot de passe"))
            {
                textMdp.Text = "";
                textMdp.UseSystemPasswordChar = false;
                textMdp.PasswordChar = '*';
                textMdp.ForeColor = Color.WhiteSmoke; // changer la couleur du texte
            }
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            if (textNom.Text.Equals(""))
            {
                textNom.Text = "Nom d'utilisateur";
                textNom.ForeColor = Color.Silver; // changer la couleur du texte
            }
        }

        private void textMdp_Leave(object sender, EventArgs e)
        {
            if (textMdp.Text.Equals(""))
            {
                textMdp.Text = "Mot de passe";
                textMdp.UseSystemPasswordChar = true; // desactiver le mot de passe
                textMdp.ForeColor = Color.Silver; // changer la couleur du texte
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (testObligatoire() == null)
            {
                //Utilisateur existe
                if(C.Connexionvalide(db, textNom.Text, textMdp.Text)==true)
                {
                    MessageBox.Show("Connecté !", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else //Utilisateur n'existe pas
                {
                    MessageBox.Show("Utilisateur n'existe pas !", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show(testObligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
