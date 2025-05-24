using Npgsql;
using Project_PBO.Model.Admin;
using Project_PBO.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.Controller.Admin
{
    class KelolaKendaraanController
    {
        private DBConnection db = new DBConnection();
        public DataTable GetAllMobil()
        {
            DataTable dt = new DataTable();
            using (var conn = db.GetConnection())
            {
                string query = "SELECT * FROM mobil ORDER BY id_mobil";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        

        public void InsertMobil(Mobil mobil)
        {
            using (var conn = db.GetConnection()) // koneksi baru setiap kali
            {
                conn.Open();
                string query = "INSERT INTO mobil (merek, tipe, kapasitas_penumpang, harga, status_ketersediaan) " +
                               "VALUES (@merek, @tipe, @kapasitas, @harga, @status)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("merek", mobil.merek);
                    cmd.Parameters.AddWithValue("tipe", mobil.tipe);
                    cmd.Parameters.AddWithValue("kapasitas", mobil.kapasitas_penumpang);
                    cmd.Parameters.AddWithValue("harga", mobil.harga);
                    cmd.Parameters.AddWithValue("status", mobil.status_ketersediaan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool UpdateMobil(int id, string merek, string tipe, int kapasitas, decimal harga, string status)
        {
            using (var conn = db.GetConnection())
            {
                string query = @"UPDATE mobil SET merek = @merek, tipe = @tipe, kapasitas_penumpang = @kapasitas,
                                 harga = @harga, status_ketersediaan = @status WHERE id_mobil = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("merek", merek);
                    cmd.Parameters.AddWithValue("tipe", tipe);
                    cmd.Parameters.AddWithValue("kapasitas", kapasitas);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("id", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteMobil(int id)
        {
            using (var conn = db.GetConnection())
            {
                string query = "DELETE FROM mobil WHERE id_mobil = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
