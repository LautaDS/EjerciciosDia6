using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia6
{
    class Cola<T> : AlterList<T>
    {
        public T DeStack()
        {
            if (colaT.Count > 0)
            {
                T elementToReturn = colaT[0];
                colaT.RemoveAt(0);
                return elementToReturn;
            }
             else
            {
                return default;
            }
        }



    }
}
