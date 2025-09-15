namespace methodology
{
    public class CompareBySeniority : IcomparableStrategy
    {
        //sosIgual
        public bool isEqual(IComparable a, IComparable b) => ((Teacher)a).getSeniority() == ((Teacher)b).getSeniority();

        //sosMenor
        public bool isSmaller(IComparable a, IComparable b) => ((Teacher)a).getSeniority() < ((Teacher)b).getSeniority();

        //sosMayor
        public bool isBigger(IComparable a, IComparable b) => ((Teacher)a).getSeniority() > ((Teacher)b).getSeniority();

        public string getValue(IComparable a) => ((Teacher)a).getSeniority().ToString();
    }
}