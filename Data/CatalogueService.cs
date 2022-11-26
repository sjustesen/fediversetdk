using Fediverset.Data;
using Fediverset.Interfaces;
using Fediverset.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Fediverset.Services;

public class CatalogueService : IService
{
    private IConfiguration _settings { get; set; }
    private DbContextOptions<CatalogueContext> _optionsBuilder;

    public CatalogueService(IConfiguration databaseSettings)
    {
        _settings = databaseSettings;
        _optionsBuilder = new DbContextOptions<CatalogueContext>();
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
        using (var context = new CatalogueContext(_optionsBuilder))
        {
            context.Database.EnsureCreated();

            //context.Category
        }

        return new List<T>();
    }
}