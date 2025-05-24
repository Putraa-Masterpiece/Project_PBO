using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO.Tools
{
    class DBConnection
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345;Database=project_pbo";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
