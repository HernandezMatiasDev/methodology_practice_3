using System;

namespace methodology
{
    public class KeyboardStudentFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            Console.WriteLine("    Creacion de Estudiante");

            Console.WriteLine("Ingrese el nombre completo del estudiante");
            string name = DataReader.stringByKeyboard();

            Console.WriteLine("Ingrese el DNI");
            int dni = DataReader.numberByKeyboard();

            Console.WriteLine("Ingrese el legajo");
            int id = DataReader.numberByKeyboard();

            Console.WriteLine("Ingrese el promedio");
            double average = DataReader.doubleByKeyboard();

            return new Student(name, dni, id, average);
        }
    }
}