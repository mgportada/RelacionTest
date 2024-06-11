using System;

namespace sumaTresNumerosOrdenados
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 7;
            int n3 = 2;

            bool esSuma = VerificarSuma(n1, n2, n3);
            Console.WriteLine("La suma de los dos números menores es igual al mayor: " + esSuma);
        }

        public static bool VerificarSuma(int n1, int n2, int n3)
        {
            // Primero se ordenan los números
            if (n2 < n1)
            {
                int aux = n1;
                n1 = n2;
                n2 = aux;
            }

            if (n3 < n1)
            {
                int aux = n1;
                n1 = n3;
                n3 = n2;
                n2 = aux;
            }
            else if (n3 < n2)
            {
                int aux = n2;
                n2 = n3;
                n3 = aux;
            }

            // Verificar si la suma de los dos menores es igual al mayor
            if (n1 + n2 == n3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}