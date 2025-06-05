using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISurveyRepository : IGenericRepository<Survey>
    {
        Task<IEnumerable<Survey>> GetSurveysMostExpensive(double cantidad);
    }
}