using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosDia6
{
    class ListaRectangulos : ListaDevPlace<Rectangulo>
    {
        private List<Rectangulo> listRectangulo = new List<Rectangulo>();
       
        public void AgregarItem(Rectangulo element)
        {
            listRectangulo.Add(element);
        }

        public void BorrarItem(Rectangulo element)
        {
            if (listRectangulo.Contains(element))
            {
                listRectangulo.Remove(element);
            }
        }

        public int CantidadItems()
        {
            return listRectangulo.Count();
        }

        public Rectangulo ObtenerItem(int i)
        {
            try
            {
                return listRectangulo[i];
            }
            catch
            {
                return default;
            }
        }
    }
}
