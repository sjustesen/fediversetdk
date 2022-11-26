namespace Fediverset.Interfaces;

public interface IService
{
    // T should be something, obviously...
    public List<T> Read<T>();
    public List<T> Create<T>();
    public List<T> Update<T>();
    public List<T> Delete<T>();
}