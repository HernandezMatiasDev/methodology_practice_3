using System;

namespace methodology
{
    public static class DataReader
    {
        public static int numberByKeyboard()
        {
            int value = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Ingrese un numero: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out value))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Entrada invalida, por favor ingrese un numero: ");
                }
            }
            return value;
        }

        public static string stringByKeyboard()
        {
            Console.Write("Ingrese un valor: ");
            return Console.ReadLine();
        }

        public static double doubleByKeyboard()
        {
            double value = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Ingrese un número decimal: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, por favor ingrese un número decimal.");
                }
            }
            return value;
        }
    }
}