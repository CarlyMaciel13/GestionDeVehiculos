using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVehiculos.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }

        public Vehiculo() 
        {
        }

        public Vehiculo(int id, string marca, string modelo, int año, string color, string patente, string tipo)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
            Patente = patente;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return string.Concat("id: ", Id, 
                               "\nMarca: ", Marca,
                               "\nModelo: ", Modelo,
                               "\nAño: ", Año,
                               "\nColor: ", Color,
                               "\nPatente: ", Patente, 
                               "\nTipo: ", Tipo);
        }
    }
}
