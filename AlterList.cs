using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia6
{
    abstract class AlterList <T>
    {
        protected List<T> colaT = new List<T>();

        public void AddElement(T element)
        {
            colaT.Add(element);
        }

    }
}
