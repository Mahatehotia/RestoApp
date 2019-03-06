using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Model
{
    class Commandes
    {
        public int idCommande { get; set; }
        public string nomCommande { get; set; }
        public float coutCommande { get; set; }

        public enum etatCommande
        {
        }
        public int id_panier { get; }
        public int id_client { get; }
        public int id_table { get; }

      
    }


}
