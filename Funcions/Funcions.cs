using System;
using System.IO;
using System.Collections.Generic;

namespace methodology
{
    public static class Funcions
    {

        //llenar(Coleccionable)
        public static void RandomLoadComparable(ICollectable collectable, int typeComparable, int load = 20)
        {
            for (int i = 0; i < load; i++)
            {
                IComparable comparable = ComparableFactory.createRandom(typeComparable);
                collectable.add(comparable);
            }
        }

        public static void KeyboardLoadComparable(ICollectable collectable, int typeComparable, int load = 3)
        {
            for (int i = 0; i < load; i++)
            {
                IComparable comparable = ComparableFactory.createByKeyboard(typeComparable);
                collectable.add(comparable);
            }
        }

        //informar(Coleccionable)
        // Esta funcion acutalmente compara por un valor y no tiene la necesidad de crear instancias.
        public static void inform(ICollectable collectable)
        {
            Console.WriteLine($"Información de {collectable.GetType().Name}:");
            Console.WriteLine($"La {collectable.GetType().Name} tiene {collectable.amount()} elementos");
            Console.WriteLine($"El valor minimo de la {collectable.GetType().Name} es {((INumberComparable)collectable.minimum()).getValue()}");
            Console.WriteLine($"El valor maximo de la {collectable.GetType().Name} es {((INumberComparable)collectable.maximum()).getValue()}");

            if (collectable.containsValue(DataReader.stringByKeyboard()))
            {
                Console.WriteLine("El valor introducido esta en la coleccion");
            }
            else
            {
                Console.WriteLine("El valor introducido no se encuentra en la coleccion");
            }


        }


        public static void changeStrategy(Collectable collectable, IcomparableStrategy comparableStrategy)
        {
            Iiterator iterator = collectable.createIterator();
            while (!iterator.End())
            {
                ((IUseCompareStrategy)iterator.Current()).setStrategy(comparableStrategy);
                iterator.Next();
            }
        }
        public static void printCollectable(Collectable collectable)
        {
            Iiterator iterator = collectable.createIterator();
            while (!iterator.End())
            {
                Console.WriteLine(iterator.Current().ToString());
                iterator.Next();
            }

        }

        public static void dictationClasses(Teacher teacher, int timeClass = 5)
        {
            for (int i = 0; i < timeClass; i++)
            {
                teacher.speakClass();
                teacher.writeBlackboard();
            }
        }

        public static void conectToObserved(IObserved observed, IObserver Observer)
        {
            observed.AddObserver(Observer);
        }

        // una lista de observadores se conectan con un observado
        public static void AttachObservers(IObserved observed, Collectable collectable)
        {
            Iiterator iterator = collectable.createIterator();
            for (iterator.First(); !iterator.End(); iterator.Next())
            {
                conectToObserved(observed, (IObserver)iterator.Current());
            }
        }

        // un observador se conecta a una lista de observados 
        public static void SubscribeToSubjects(IObserver observer, Collectable collectable)
        {
            Iiterator iterator = collectable.createIterator();
            for (iterator.First(); !iterator.End(); iterator.Next())
            {
                conectToObserved((IObserved)iterator.Current(), observer);
            }
        }
        public static Queue studentList(Collectable collectable)
        {
            Queue queue = new Queue();
            Iiterator iterator = collectable.createIterator();
            for (iterator.First(); !iterator.End(); iterator.Next())
            {
                queue.add(new Name(((Person)iterator.Current()).getName()));
            }
            return queue;
        }

    }
}
