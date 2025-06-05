using System.Linq;
using Domain.Entities;
using Infrastructure.Data;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class CategoriesCatalogRepository : GenericRepository<CategoriesCatalog>, ICategoriesCatalogRepository
    {
        private readonly ApisurveyDbContext _context;

        public CategoriesCatalogRepository(ApisurveyDbContext context) : base(context)
        {
            _context = context;
        }

        public void Add(CategoryOption entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<CategoryOption> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryOption> Find(Expression<Func<CategoryOption, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public new Task<IEnumerable<CategoryOption>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryOption> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriesCatalog>> GetCategoriesCatalogMostExpensive(double cantidad)
        {
            throw new NotImplementedException();
        }

        public void Remove(CategoryOption entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<CategoryOption> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryOption entity)
        {
            throw new NotImplementedException();
        }
    }
}