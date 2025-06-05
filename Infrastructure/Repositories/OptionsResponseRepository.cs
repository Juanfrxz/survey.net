using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class OptionsResponseRepository : GenericRepository<OptionsResponse>, IOptionsResponseRepository
    {
        public OptionsResponseRepository(ApisurveyDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<OptionsResponse>> GetOptionsResponsesMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }
    }
}