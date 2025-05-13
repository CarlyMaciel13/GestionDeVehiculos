using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeVehiculos.GuardClause
{
    public class GuardClause
    {
        /// Valida si una opción ingresada por el usuario está dentro del rango especificado.
        public static int ValidarOpcion(int minimo, int maximo)
        {
            bool pudo = false;
            int opcion = 0;
            while (!pudo)
            {
                pudo = int.TryParse(Console.ReadLine(), out opcion);
                if (!pudo || opcion < minimo || opcion > maximo)
                {
                    pudo = false;
                    Console.WriteLine(string.Concat("Solo numeros entre ", minimo, " y ", maximo, ".\nIntente nuevamente: "));
                }
            }
            return opcion;
        }
    }
}
