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
        private readonly string connectionString = "Server=LAPTOP-8GCRCA54\\SQLEXPRESS01;Initial Catalog= GestionDV; Integrated Security=true;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
