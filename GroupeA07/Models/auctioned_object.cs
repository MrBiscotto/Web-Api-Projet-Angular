//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroupeA07.Models
{
    using System;
    using System.Collections.Generic;
	using System.Data.SqlClient;

	public partial class Auctioned_object
    {
        public int idObject { get; set; }
        public string nameObject { get; set; }
        public string descriptionObject { get; set; }
        public int priceObject { get; set; }
        public System.DateTime sellingDate { get; set; }
        public int idUser { get; set; }
        public string catObject { get; set; }

	}
}
