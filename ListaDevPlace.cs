using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia6
{
    interface ListaDevPlace <T>
    {
        public void AgregarItem(T element);
        public void BorrarItem(T element);
        public T ObtenerItem(int i);
        public int CantidadItems();
    }
}
