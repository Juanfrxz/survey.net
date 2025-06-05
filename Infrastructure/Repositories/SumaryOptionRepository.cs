using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class SumaryOptionRepository : GenericRepository<SumaryOption>, ISumaryOptionRepository
    {
        public SumaryOptionRepository(ApisurveyDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<SumaryOption>> GetSumaryOptionsMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }
    }
}