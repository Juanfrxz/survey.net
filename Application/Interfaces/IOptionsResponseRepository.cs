using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOptionsResponseRepository : IGenericRepository<OptionsResponse>
    {
        Task<IEnumerable<OptionsResponse>> GetOptionsResponsesMostExpensive(double cantidad);
    }
}