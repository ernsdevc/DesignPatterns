namespace DesignPattern.Iterator.Itaretor
{
    public interface IIterator<T>
    {
        T CurrentItem { get; }
        bool NextLocation();
    }
}
