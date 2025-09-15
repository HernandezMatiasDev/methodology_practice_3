using System;

namespace methodology
{
    public class KeyboardTeacherFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {
            Console.WriteLine("    Creacion de Estudiante");

            Console.WriteLine("Ingrese el nombre completo del estudiante");
            string name = DataReader.stringByKeyboard();

            Console.WriteLine("Ingrese el DNI");
            int dni = DataReader.numberByKeyboard();

            Console.WriteLine("Ingrese el legajo");
            int seniority = DataReader.numberByKeyboard();

            return new Teacher(name, dni, seniority);
        }
    }
}