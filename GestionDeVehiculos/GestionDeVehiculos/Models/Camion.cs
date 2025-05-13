using GestionDeVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVehiculos.Models
{
    public class Camion : Vehiculo, IVehiculoMotorizado, IVehiculoDeCarga
    {
        public int VelocidadMaxima { get; set; }
        public string TipoCombustible { get; set; }
        public int CapacidadCarga { get; set; }
        public string TipoCarga { get; set; }

        public Camion()
        {
            //SE LE ASIGNA EL TIPO DIRECTAMENTE EN LA CLASE
            Tipo = "Camion";
        }

        public Camion(int id, string marca, string modelo, int año, string color, string patente, string tipo,
                      int velocidadMaxima, string tipoCombustible, int capacidadCarga, string tipoCarga)
            : base(id, marca, modelo, año, color, patente, tipo)
        {
            VelocidadMaxima = velocidadMaxima;
            TipoCombustible = tipoCombustible;
            CapacidadCarga = capacidadCarga;
            TipoCarga = tipoCarga;
        }

        public override string ToString()
        {
            return string.Concat("Velocidad Maxima: ", VelocidadMaxima,
                               "\nTipo de Combustible: ", TipoCombustible, 
                               "\nCapacidad de Carga: ", CapacidadCarga,
                               "\nTipo de Carga: ", TipoCarga);
        }

        /// METODOS POR PARTE DE LAS INTERFACES
        public int ObtenerVelocidadMaxima() => VelocidadMaxima;

        public void MostrarTipoCombustible()
        {
            Console.WriteLine($"Tipo de combustible: {TipoCombustible}");
        }

        public int ObtenerCapacidadCarga() => CapacidadCarga;

        public void MostrarTipoCarga()
        {
            Console.WriteLine($"Tipo de carga: {TipoCarga}");
        }
    }
}
