using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICategoryOptionRepository : IGenericRepository<CategoryOption>
    {
        Task<IEnumerable<CategoryOption>> GetCategoryOptionsMostExpensive(double cantidad);
    }
}