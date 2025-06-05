using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class OptionQuestionRepository : GenericRepository<OptionQuestion>, IOptionQuestionRepository
    {
        public OptionQuestionRepository(ApisurveyDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<OptionQuestion>> GetOptionQuestionsMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }
    }
}