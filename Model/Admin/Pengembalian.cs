using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.Model.Admin
{
    class Pengembalian
    {
        public int id_pengembalian { get; set; }
        public int id_sewa { get; set; }
        public DateTime tanggal_pengembalian { get; set; }
        public int denda { get; set; }

    }
}
