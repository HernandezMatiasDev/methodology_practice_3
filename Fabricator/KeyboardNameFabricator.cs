using System;

namespace methodology
{
    public class KeyboardNameFabricator : ComparableFactory
    {
        public override IComparable CreateComparable()
        {

            Console.WriteLine("Ingrese el nombre: ");
            string name = DataReader.stringByKeyboard();

            return new Name(name);
        }
    }
}