using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISubQuestionRepository : IGenericRepository<SubQuestion>
    {
        Task<IEnumerable<SubQuestion>> GetSubQuestionsMostExpensive(double cantidad);
    }
}