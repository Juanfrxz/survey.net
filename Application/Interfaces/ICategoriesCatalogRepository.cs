using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICategoriesCatalogRepository : IGenericRepository<CategoriesCatalog>
    {
        Task<IEnumerable<CategoriesCatalog>> GetCategoriesCatalogMostExpensive(double cantidad);   
    }
}