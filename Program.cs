using System;

namespace methodology
{
    class Program
    {
        const int numberType = 1;
        const int studentType = 2;
        private const int nameType = 3;
        private const int teacherType = 4;
        static void Main(string[] args)
        {
            // Collectable stack = new Stack();
            // Collectable queue = new Queue();
            // Collectable unique = new UniqueCollection();

            // MultipleCollection multiple = new MultipleCollection(stack, queue);

            // Funcions.RandomLoadComparable(stack, numberType);
            // Funcions.RandomLoadComparable(queue, numberType);


            // Funcions.inform(stack);
            // Funcions.inform(queue);
            // Funcions.inform(multiple);

            // Funcions.RandomLoadComparable(stack, studentType);
            // Funcions.RandomLoadComparable(queue, studentType);
            // Funcions.RandomLoadComparable(unique, studentType);


            // Funcions.printCollectable(stack);
            // Funcions.printCollectable(queue);
            // Funcions.printCollectable(unique);

            // Funcions.inform(stack);
            // Funcions.changeStrategy(stack, new CompareByAverage());
            // Funcions.inform(stack);
            // Funcions.changeStrategy(stack, new CompareByDni());
            // Funcions.inform(stack);
            // Funcions.changeStrategy(stack, new CompareByName());
            // Funcions.inform(stack);


            // observer
            // // creamos al profesor
            // IComparable teacher1 = ComparableFactory.createRandom(teacherType);
            // Console.WriteLine(teacher1.ToString());

            // // creo colas para los alumnos
            // Collectable studentStack = new Stack();

            // Funcions.RandomLoadComparable(studentStack, studentType, 3);

            // Funcions.AttachObservers((IObserved)teacher1, studentStack);
            // Funcions.dictationClasses((Teacher)teacher1);

            // como funciono la actividad, voy a experimentar con takeList

            // creamos al profesor
            IComparable teacher1 = ComparableFactory.createRandom(teacherType);
            Console.WriteLine($"profesor: {teacher1.ToString()}");

            // creo una collecion de eliminacion random para los alumnos
            RandomElimination student = new RandomElimination();

            // creamos la lista de estudiantes
            Funcions.RandomLoadComparable(student, studentType, 30);
            Queue studentList_1 = Funcions.studentList(student);


            // quitamos estudiantes para que algunos esten ausentes
            // pensaba hacer una funcion pero creo que no es necesario
            for (int i = 0; i < 10; i++)
            {
                student.randomRemove();
            }

            // conectamos a los estudiantes para que oberven al profesor
            Funcions.AttachObservers((IObserved)teacher1, student);

            // conectamos al profesor para que oberve a los estudiantes
            Funcions.SubscribeToSubjects((IObserver)teacher1, student);


            // el profesor pasa lista:
            Iiterator studentListIterator = studentList_1.createIterator();
            ((Teacher)teacher1).takeList(studentListIterator);
            

            

        }
    }
}
