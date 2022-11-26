using Fediverset.Data;
using Fediverset.Interfaces;

namespace Fediverset.Services;

public class CatalogueService : IService
{
    public List<T> Delete<T>()
    {
        throw new NotImplementedException();
    }

    public List<T> Read<T>()
    {
        throw new NotImplementedException();
    }

    public List<T> Update<T>()
    {
        throw new NotImplementedException();
    }

    public List<T> Create<T>()
    {
        using(var context = new CatalogueContext()) {
            context.Database.EnsureCreated();

            context.Category
        }
    }
}