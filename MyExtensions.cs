using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia6
{
    public static class MyExtensions
    {
        public static string ReturnFirstHalfofString(this string str)
        {
            char[] charArray = str.ToCharArray(); ;
            int firstHalf = charArray.Length / 2;
            string halfString = new string(charArray, 0, firstHalf);

            return halfString;
        }

        public static string ReturnLastHalfofString(this string str)
        {
            char[] charArray = str.ToCharArray(); ;
            int half = charArray.Length / 2;
            string lastHalfString = new string(charArray, half, charArray.Length);
            return lastHalfString;
        }

        public static bool EsMayorDeEdad(this Persona persona)
        {
            if(persona.Edad() >= 18)
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        public static void PrintEveryItemInList<T>(this List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void PrintUpToValue(this int value, int UpTo)
        {
            for (int i = value; i <= UpTo; i++)
                Console.Write(i);
        }

        public static int ReturnIntPart (this double value)
        {
            return ((int)value);
        }

        public static double ReturnDecimalPart(this double value)
        {
            double decimals = value - Math.Truncate(value);
            return decimals;
        }
    }
}
