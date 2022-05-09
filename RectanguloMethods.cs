using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia6
{
    public partial class Rectangulo
    {
        public double RetornarSuperficie()
        {
            return Lado1 * Lado2;
        }

        public double RetornarPerimetro()
        {
            return (Lado1 * 2) + (Lado2 * 2);
        }
    }
}
