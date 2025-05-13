using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GestionDeVehiculos.Context
{
    public class VehiculoContext
    {
        private readonly string connectionString = "Server=DESKTOP-IE4M0CJ\\SQLEXPRESS;Database=GestionDV;UID=sa;PWD=12345678;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
