using System;

namespace Burbuja
{
    public class Program
    {
        public static void Main()
        {
            // Entradas
            int[] sec = { 5, 3, 8, 4, 2 };

            // Llamada al método de ordenación
            OrdenarBurbuja(sec);

            // Salida
            foreach (int num in sec)
            {
                Console.Write(num + " ");
            }
        }

        public static void OrdenarBurbuja(int[] sec)
        {
            for (int i = 0; i < sec.Length; i++)
            {
                for (int j = i + 1; j < sec.Length; j++)
                {
                    if (sec[i] > sec[j])
                    {
                        int aux = sec[i];
                        sec[i] = sec[j];
                        sec[j] = aux;
                    }
                }
            }
        }
    }
}