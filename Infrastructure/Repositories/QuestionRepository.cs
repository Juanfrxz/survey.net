using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApisurveyDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Question>> GetQuestionsMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }
    }
}