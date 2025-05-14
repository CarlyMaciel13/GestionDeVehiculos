using GestionDeVehiculos.Models;
using GestionDeVehiculos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            VehiculoService vehiculoService = new VehiculoService();

            List<Vehiculo> lista = vehiculoService.ObtenerTodosLosVehiculos();
            foreach(var vehiculo in lista)
            {
                Console.WriteLine(vehiculo.ToString());
            }
            Vehiculo vehiculo1 = new Vehiculo(0, "Toyota", "Corolla", 2020, "Rojo", "ABC123", "Auto");
            vehiculoService.AgregarVehiculo(vehiculo1);
        }
    }
}
