namespace DesignPattern.Iterator.Itaretor
{
    public interface IMover<T>
    {
        IIterator<T> CreateIterator();
    }
}
