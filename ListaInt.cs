using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosDia6
{
    class ListaInt : ListaDevPlace<int>
    {
        private List<int> listaInt = new List<int>();


        public void AgregarItem(int element)
        {
            listaInt.Add(element);
        }

        public void BorrarItem(int element)
        {
            if (listaInt.Contains(element))
            {
                listaInt.Remove(element);
            }
        }

        public int CantidadItems()
        {
            return listaInt.Count();
        }

        public int ObtenerItem(int i)
        {
            try
            {
                return listaInt[i];
            }
             catch
            {
                return default;
            }
        }
    }
}
