namespace methodology
{
    public class Student : Person, IUseCompareStrategy, IObserver, IObserved
    {
        //legajo
        private int studentID;

        private List<IObserver> observers = new List<IObserver>();
        private string[] distractTexts =
        {
            "Mirando el celular",
            "Dibujando en el margen de la carpeta",
            "Tirando aviones de papel"
        };


        //promedio
        private double average;

        private IcomparableStrategy comparableStrategy;

        public Student(string name, int dni, int id, double average) : base(name, dni)
        {
            this.studentID = id;
            this.average = average;
            comparableStrategy = new CompareByStudentId();
        }

        public int getStudentID() => studentID;
        public double getAverage() => average;

        public void setStrategy(IcomparableStrategy comparableStrategy)
        {
            this.comparableStrategy = comparableStrategy;
        }
        public override string getValue()
        {
            return comparableStrategy.getValue(this);
        }

        public override bool isEqual(IComparable c)
        {
            return comparableStrategy.isEqual(this, (Student)c);
        }

        public override bool isSmaller(IComparable c)
        {
            return comparableStrategy.isSmaller(this, (Student)c);
        }
        public override bool isBigger(IComparable c)
        {
            return comparableStrategy.isBigger(this, (Student)c);
        }

        public void AddObserver(IObserver observer) => observers.Add(observer);
        public void RemoveObserver(IObserver observer) => observers.Remove(observer);
        public void Call(string message)
        {
            foreach (IObserver obs in observers)
                obs.Update(message);
        }

        public void attention() => Console.WriteLine("Prestando atención");

        public void distract() => Console.WriteLine(distractTexts[RandomDataGenerator.IntegerRandomNumber(distractTexts.Count())]);
        public void present() => Console.WriteLine($"Alumno {getName()}: Presente");
        public void Update(string message)
        {
            if (message == "talk")
            {
                attention();
            }
            else if (message == "write")
            {
                distract();
            }
            else if (message == this.getName())
            {
                present();
                Call("present");
            }
        }
        // Use este metodo porque lo necesite en print_student_list de Funcions
        public override string ToString()
        {
            return $"Nombre: {name}, DNI: {dni}, Legajo: {studentID}, Promedio: {average}";
        }
    }
}