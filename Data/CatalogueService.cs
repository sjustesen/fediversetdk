using Fediverset.Data;
using Fediverset.Interfaces;
using Fediverset.Models;
using Microsoft.Extensions.Options;

namespace Fediverset.Services;

public class CatalogueService : IService
{
    public IConfiguration _settings { get; set; }

    public CatalogueService(IConfiguration databaseSettings)
    {
        this._settings = databaseSettings;
    }
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
        using (var context = new CatalogueContext(_settings))
        {
            context.Database.EnsureCreated();

            //context.Category
        }

        return new List<T>();
    }
}