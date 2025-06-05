using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IChapterRepository Chapters { get; }
        IQuestionRepository Questions { get; }
        IOptionQuestionRepository OptionQuestions { get; }
        IOptionsResponseRepository OptionsResponses { get; }
        ISurveyRepository Surveys { get; }
        ISumaryOptionRepository SumaryOptions { get; }
        ISubQuestionRepository SubQuestions { get; }
        ICategoriesCatalogRepository CategoriesCatalogs { get; }
        ICategoryOptionRepository CategoryOptions { get; }
        Task<int> SaveAsync();
    }
}