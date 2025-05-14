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
                    int velocidadMaxima = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                    string tipoCombustible = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                    int capacidadCarga = reader.IsDBNull(9) ? 0 : reader.GetInt32(9);
                    string tipoCarga = reader.IsDBNull(10) ? string.Empty : reader.GetString(10);

                    Vehiculo vehiculo = new Vehiculo(id, marca, modelo, año, color, patente, tipo)
;

                    vehiculos.Add(vehiculo);
                }

                reader.Close();
            }

            return vehiculos;
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            string query = "INSERT INTO Vehiculos (marca, modelo, año, color, patente, tipo) VALUES (@marca, @modelo, @año, @color, @patente, @tipo)";
            using (SqlConnection connection = vehiculoContext.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@marca", vehiculo.Marca);
                command.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                command.Parameters.AddWithValue("@año", vehiculo.Año);
                command.Parameters.AddWithValue("@color", vehiculo.Color);
                command.Parameters.AddWithValue("@patente", vehiculo.Patente);
                command.Parameters.AddWithValue("@tipo", vehiculo.Tipo);
                if (vehiculo.Tipo == "Automovil")
                {
                    command.Parameters.AddWithValue("@velocidadMaxima", ((Automovil)vehiculo).VelocidadMaxima);
                    command.Parameters.AddWithValue("@tipoCombustible", ((Automovil)vehiculo).TipoCombustible);
                }
                if (vehiculo.Tipo == "Motocicleta")
                {
                    command.Parameters.AddWithValue("@velocidadMaxima", ((Motocicleta)vehiculo).VelocidadMaxima);
                    command.Parameters.AddWithValue("@tipoCombustible", ((Motocicleta)vehiculo).TipoCombustible);
                }
                if (vehiculo.Tipo == "Camion")
                {
                    command.Parameters.AddWithValue("@velocidadMaxima", ((Camion)vehiculo).VelocidadMaxima);
                    command.Parameters.AddWithValue("@tipoCombustible", ((Camion)vehiculo).TipoCombustible);
                    command.Parameters.AddWithValue("@capacidadCarga", ((Camion)vehiculo).CapacidadCarga);
                    command.Parameters.AddWithValue("@tipoCarga", ((Camion)vehiculo).TipoCarga);
                }
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
