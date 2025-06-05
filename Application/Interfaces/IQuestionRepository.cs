using Domain.Entities;

namespace Application.Interfaces
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        Task<IEnumerable<Question>> GetQuestionsMostExpensive(double cantidad);
    }
}