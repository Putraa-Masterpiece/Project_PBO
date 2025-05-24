using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.Model.Admin
{
    class sewa
    {
        public int id_sewa { get; set; }
        public int id_user { get; set; }
        public int id_mobil { get; set; }
        public int id_supir { get; set; }
        public int durasi_peminjaman { get; set; }
        public DateTime tanggal_peminjaman { get; set; }
        public DateTime tanggal_pengembalian { get; set; }
        public int total_harga { get; set; }
        public bool dengan_supir { get; set; }



    }
}
