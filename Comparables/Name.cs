namespace methodology
{
    public class Name : INumberComparable
    {
        //valor
        private string value;

        //constructor(v)
        public Name(string value)
        {
            this.value = value;
        }

        // getValor
        public string Value => value;

        public string getValue()
        {
            return value;
        }

        public override string ToString()
        {
            return $"Nombre: {value}";
        }

        //sosIgual
        public bool isEqual(IComparable c){return false;}

        //sosMenor
        public bool isSmaller(IComparable c){return false;}

        //sosMayor
        public bool isBigger(IComparable c){return false;}
    }   
}