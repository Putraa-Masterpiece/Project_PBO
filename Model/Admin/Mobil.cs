using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.Model.Admin
{
    class Mobil
    {
        public string id_mobil { get; set; }
        public string merek { get; set; }
        public string tipe { get; set; }
        public int kapasitas_penumpang { get; set; }
        public decimal harga { get; set; }
        public string status_ketersediaan { get; set; }
       
    }
}
