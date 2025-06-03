using Microsoft.EntityFrameworkCore; 
using Domain.Entities;
using System.Reflection;

namespace Infrastructure.Data { 
    public class ApisurveyDbContext : DbContext { 
        public ApisurveyDbContext(DbContextOptions<ApisurveyDbContext> options) : base(options) {} 

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SubQuestion> SubQuestions { get; set; }
        public DbSet<OptionQuestion> OptionQuestions { get; set; }
        public DbSet<OptionsResponse> OptionsResponses { get; set; }
        public DbSet<SumaryOption> SumaryOptions { get; set; }
        public DbSet<CategoriesCatalog> CategoriesCatalogs { get; set; }
        public DbSet<CategoryOption> CategoryOptions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    } 
} 
