//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDeStock
{
    using System;
    using System.Collections.Generic;
    
    public partial class Details_Commande
    {
        public int ID_Commande { get; set; }
        public int ID_Produit { get; set; }
        public int Quantite { get; set; }
    
        public virtual Commande Commande { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
