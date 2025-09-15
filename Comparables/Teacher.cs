namespace methodology
{
    public class Teacher : Person, IUseCompareStrategy, IObserved, IObserver
    {
        int seniority;
        private List<IObserver> observers = new List<IObserver>();

        // es para pasar lista
        private bool present = false;
        private IcomparableStrategy comparableStrategy;
        
        public Teacher(string name, int dni, int seniority) : base(name, dni)
        {
            this.seniority = seniority;

            comparableStrategy = new CompareBySeniority();
        }

        public int getSeniority() => seniority;

        public void setStrategy(IcomparableStrategy comparableStrategy)
        {
            this.comparableStrategy = comparableStrategy;
        }
        
        public void AddObserver(IObserver observer) => observers.Add(observer);
        public void RemoveObserver(IObserver observer) => observers.Remove(observer);
        public void Call(string message)
        {
            foreach (IObserver obs in observers)
                obs.Update(message);
        }

        // Esta funcion es porque queria experimentar con el oberver
        public void takeList(Iiterator studentList)
        {
            for (studentList.First(); !studentList.End(); studentList.Next())
            {
                Console.WriteLine(((Name)studentList.Current()).getValue().ToUpper());
                Call(((Name)studentList.Current()).getValue());
                if (present)
                {
                    Console.WriteLine($"profesor: muy bien {((Name)studentList.Current()).getValue()}");
                    present = false;
                }
                else
                {
                    Console.WriteLine($"profesor: {((Name)studentList.Current()).getValue()} Ausente");
                }
            }
        }
        //
        public void Update(string message)
        {
            if (message == "present")
            {
                present = true;
            }
        }

        public void speakClass()
        {
            Console.WriteLine("Hablando de algún tema");
            Call("talk");
        }

        public void writeBlackboard()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
            Call("write");
        }
        public override string ToString()
        {
            return $"Nombre: {name}, DNI: {dni}, Antiguedad: {seniority}";
        }

    }
}
