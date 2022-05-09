using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia6
{
    public partial class Persona
    {
        public int Edad()
        {
            return 2022 - this.fecNacimiento;
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

    }
}
