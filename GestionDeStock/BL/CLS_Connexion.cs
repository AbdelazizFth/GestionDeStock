using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    internal class CLS_Connexion
    {
        //fonction pour vérifier la connexion
        public bool Connexionvalide(dbStockContext db, string Nom, string Mdp)
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Nom_Utilisateur = Nom;
            utilisateur.Mdp_Utilisateur = Mdp;
            //Si le nom et le mot de passe existe dans la base de données et qu'ils ne sont pas null
            if (db.Utilisateurs.SingleOrDefault(s=>s.Nom_Utilisateur == Nom && s.Mdp_Utilisateur == Mdp)!= null)
            {
                return true;
            }
            else //s'ils n'existent pas
                { return false; }   
        }
    }
}
