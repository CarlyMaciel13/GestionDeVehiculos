using GestionDeVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVehiculos.Models
{
    public class Automovil : Vehiculo, IVehiculoMotorizado
    {
        public int VelocidadMaxima { get; set; }
        public string TipoCombustible { get; set; }

        public Automovil()
        {
            //SE LE ASIGNA EL TIPO DIRECTAMENTE EN LA CLASE
            this.Tipo = "Automovil";
        }

        public Automovil(int id, string marca, string modelo, int año, string color, string patente, string tipo,
                         int velocidadMaxima, string tipoCombustible)
            : base(id, marca, modelo, año, color, patente, tipo)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
            Patente = patente;
            Tipo = tipo;
            this.VelocidadMaxima = velocidadMaxima;
            this.TipoCombustible = tipoCombustible;
        }

        public override string ToString()
        {
            return string.Concat("Velocidad Maxima: ", VelocidadMaxima,
                               "\nTipo de Combustible: ", TipoCombustible);
        }

        /// METODOS POR PARTE DE LA INTERFACE
        public int ObtenerVelocidadMaxima() => VelocidadMaxima;

        public void MostrarTipoCombustible()
        {
            Console.WriteLine($"Tipo de combustible: {TipoCombustible}");
        }
    }
}
