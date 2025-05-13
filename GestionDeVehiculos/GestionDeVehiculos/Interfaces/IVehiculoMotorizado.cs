using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVehiculos.Interfaces
{
    public interface IVehiculoMotorizado
    {
        int ObtenerVelocidadMaxima();
        void MostrarTipoCombustible();
    }
}
