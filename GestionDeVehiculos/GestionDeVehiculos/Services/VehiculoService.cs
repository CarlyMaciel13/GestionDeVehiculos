using GestionDeVehiculos.Context;
using GestionDeVehiculos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVehiculos.Services
{
    public class VehiculoService
    {
        private readonly VehiculoContext vehiculoContext;

        public VehiculoService()
        {
            vehiculoContext = new VehiculoContext();
        }

        public List<Vehiculo> ObtenerTodosLosVehiculos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            string query = "SELECT id, marca, modelo, año, color, patente, tipo, velocidadMaxima, tipoCombustible, capacidadCarga, tipoCarga FROM Vehiculos";

            using (SqlConnection connection = vehiculoContext.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string marca = reader.GetString(1);
                    string modelo = reader.GetString(2);
                    int año = reader.GetInt32(3);
                    string color = reader.GetString(4);
                    string patente = reader.GetString(5);
                    string tipo = reader.GetString(6);
                    int velocidadMaxima = reader.GetInt32(7);
                    string tipoCombustible = reader.GetString(8);
                    int capacidadCarga = reader.GetInt32(9);
                    string tipoCarga = reader.GetString(10);

                    Vehiculo vehiculo = new Vehiculo(id, marca, modelo, año, color, patente, tipo)
;
                    
                    vehiculos.Add(vehiculo);
                }

                reader.Close();
            }

            return vehiculos;
        }
    }
}
