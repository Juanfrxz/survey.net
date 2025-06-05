using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class SurveyRepository : GenericRepository<Survey>, ISurveyRepository
    {
        public SurveyRepository(ApisurveyDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Survey>> GetSurveysMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }
    }
}