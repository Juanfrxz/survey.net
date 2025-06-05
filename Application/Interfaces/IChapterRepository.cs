using Domain.Entities;

namespace Application.Interfaces
{
    public interface IChapterRepository : IGenericRepository<Chapter>
    {
        Task<IEnumerable<Chapter>> GetChaptersMostExpensive(double cantidad);
    }
}