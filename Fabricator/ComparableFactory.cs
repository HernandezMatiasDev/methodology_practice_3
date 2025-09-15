using System;

namespace methodology
{
    public abstract class ComparableFactory
    {
        private const int number = 1;
        private const int student = 2;
        private const int name = 3;
        private const int teacher = 4;
        /// <summary>
        /// use como parametro:
        /// int 1 para number
        /// int 2 para student
        /// int 3 para nombre
        /// int 4 para profesor
        /// </summary>
        public static IComparable createRandom(int opcion)
        {
            ComparableFactory factory;
            switch (opcion)
            {
                case number:
                    factory = new RandomNumFabricator();
                    break;
                case student:
                    factory = new RandomStudentFabricator();
                    break;
                case name:
                    factory = new RandomNameFabricator();
                    break;
                case teacher:
                    factory = new RandomTeacherFabricator();
                    break;
                default:
                    throw new ArgumentException("El valor introducido no es valido, igrese 1 para Number y 2 para Student");
                    break;
            }
            return factory.CreateComparable();
        }

        /// <summary>
        /// use como parametro:
        /// int 1 para numero
        /// int 2 para aulmno
        /// int 3 para nombre
        /// int 4 para profesor
        /// </summary>
        public static IComparable createByKeyboard(int opcion)
        {
            ComparableFactory factory;
            switch (opcion)
            {
                case number:
                    factory = new KeyboardNumFabricator();
                    break;
                case student:
                    factory = new KeyboardStudentFabricator();
                    break;
                case name:
                    factory = new KeyboardNameFabricator();
                    break;
                case teacher:
                    factory = new KeyboardTeacherFabricator();
                    break;
                default:
                    throw new ArgumentException("El valor introducido no es valido, igrese 1 para Number y 2 para Student");
                    break;
            }
            return factory.CreateComparable();
        }

        public abstract IComparable CreateComparable();
    }
}