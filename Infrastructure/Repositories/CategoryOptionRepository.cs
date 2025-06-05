using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CategoryOptionRepository : GenericRepository<CategoryOption>, ICategoryOptionRepository
    {
         private readonly ApisurveyDbContext _context;

        public CategoryOptionRepository(ApisurveyDbContext context) : base(context)
        {
            _context = context;
        }

        public override void Add(CategoryOption entity)
        {
            throw new NotImplementedException();
        }

        public override void AddRange(IEnumerable<CategoryOption> entities)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<CategoryOption> Find(Expression<Func<CategoryOption, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<CategoryOption>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

        public override Task<CategoryOption> GetByIdAsync(int id)
        {
            return base.GetByIdAsync(id);
        }

        public Task<IEnumerable<CategoryOption>> GetCategoryOptionsMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }

        public override void Remove(CategoryOption entity)
        {
            throw new NotImplementedException();
        }

        public override void RemoveRange(IEnumerable<CategoryOption> entities)
        {
            throw new NotImplementedException();
        }

        public override void Update(CategoryOption entity)
        {
            throw new NotImplementedException();
        }
    }
}