namespace ISP_Follow
{
    public interface IReadable<T>
    {
        T RetrieveById(int id);
        IEnumerable<T> RetrieveAll();
    }
}
