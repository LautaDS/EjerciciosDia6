using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia6
{
    class Fila <T> : AlterList<T>
    {
        public T Dequeue()
        {
            if (colaT.Count > 0)
            {
                int last = colaT.Count -1;
                T elementToReturn = colaT[last];
                colaT.RemoveAt(last);
                return elementToReturn;
            }
            else
            {
                return default;
            }
        }
    }
}
