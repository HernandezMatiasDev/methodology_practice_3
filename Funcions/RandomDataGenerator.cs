using System;
using System.IO;
using System.Collections.Generic;

namespace methodology
{
    public static class RandomDataGenerator
    {
        private static Random random = new Random();

        // Lista con los nombres de los estudiantes
        private static List<string> studentsNames;

        // Ruta del archivo con los nombres
        private static string filepath = "./names.txt";

        public static int IntegerRandomNumber(int max, int min = 0)
        {
            return random.Next(min, max);
        }

        public static double DecimalRandomNumber(int max, int Decimals = 2)
        {
            return Math.Round(random.NextDouble() * max, Decimals);
        }


        public static string stringRandom(int amountChar)
        {
            string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string randomString = "";
            for (int i = 0; i < amountChar; i++)
            {
                randomString = randomString + Characters[IntegerRandomNumber(Characters.Length)];
            }
            return randomString;
        }

        public static string RandomName()
        {
            if (studentsNames == null || studentsNames.Count == 0)
                loadNames();

            return studentsNames[IntegerRandomNumber(studentsNames.Count)];
        }

        public static void loadNames()
        {
            if (File.Exists(filepath))
            {
                studentsNames = new List<string>(File.ReadAllLines(filepath));
            }
            else
            {
                throw new FileNotFoundException("No se encontro el archivo de nombres: " + filepath);
            }
        }

    }
}