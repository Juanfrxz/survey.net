using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOptionQuestionRepository : IGenericRepository<OptionQuestion>
    {
        Task<IEnumerable<OptionQuestion>> GetOptionQuestionsMostExpensive(double cantidad);
    }
}