using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISumaryOptionRepository : IGenericRepository<SumaryOption>
    {
        Task<IEnumerable<SumaryOption>> GetSumaryOptionsMostExpensive(double cantidad);
    }
}