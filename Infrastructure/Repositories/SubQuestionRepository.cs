using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class SubQuestionRepository : GenericRepository<SubQuestion>, ISubQuestionRepository
    {
        public SubQuestionRepository(ApisurveyDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<SubQuestion>> GetSubQuestionsMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }
    }
}