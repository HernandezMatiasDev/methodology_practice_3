namespace methodology
{
    public interface IObserved
    {
        void AddObserver(IObserver O);
        void RemoveObserver(IObserver O);
        void Call(string message);
    }
}