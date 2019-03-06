using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Model
{
    class Consommations
    {
        public int idConso { get; set; }
        public string nomConso { get; set; }
        public float prixConso { get; set; }
        public string detailConso { get; set; }


        public int id_type { get; }
    }
}
