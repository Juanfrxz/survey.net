using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApisurveyDbContext? _context;
        private IChapterRepository? _chapterRepository;
        private IQuestionRepository? _questionRepository;
        private IOptionQuestionRepository? _optionQuestionRepository;
        private IOptionsResponseRepository? _optionsResponseRepository;
        private ISurveyRepository? _surveyRepository;
        private ISumaryOptionRepository? _sumaryOptionRepository;
        private ISubQuestionRepository? _subQuestionRepository;
        private ICategoriesCatalogRepository? _categoriesCatalogRepository;
        private ICategoryOptionRepository? _categoryOptionRepository;

        public UnitOfWork(ApisurveyDbContext context)
        {
            _context = context;
        }
        public IChapterRepository Chapters {
            get
            {
                if (_chapterRepository == null)
                {
                    _chapterRepository = new ChapterRepository(_context!);
                }
                return _chapterRepository;
            }
        }
        public IQuestionRepository Questions {
            get
            {
                if (_questionRepository == null)
                {
                    _questionRepository = new QuestionRepository(_context!);
                }
                return _questionRepository;
            }
        }
        public IOptionQuestionRepository OptionQuestions {
            get
            {
                if (_optionQuestionRepository == null)
                {
                    _optionQuestionRepository = new OptionQuestionRepository(_context!);
                }
                return _optionQuestionRepository;
            }
        }
        public IOptionsResponseRepository OptionsResponses {
            get
            {
                if (_optionsResponseRepository == null)
                {
                    _optionsResponseRepository = new OptionsResponseRepository(_context!);
                }
                return _optionsResponseRepository;
            }
        }
        public ISurveyRepository Surveys {
            get
            {
                if (_surveyRepository == null)
                {
                    _surveyRepository = new SurveyRepository(_context!);
                }
                return _surveyRepository;
            }
        }
        public ISumaryOptionRepository SumaryOptions {
            get
            {
                if (_sumaryOptionRepository == null)
                {
                    _sumaryOptionRepository = new SumaryOptionRepository(_context!);
                }
                return _sumaryOptionRepository;
            }
        }
        public ISubQuestionRepository SubQuestions {
            get
            {
                if (_subQuestionRepository == null)
                {
                    _subQuestionRepository = new SubQuestionRepository(_context!);
                }
                return _subQuestionRepository;
            }
        }
        public ICategoriesCatalogRepository CategoriesCatalogs {
            get
            {
                if (_categoriesCatalogRepository == null)
                {
                    _categoriesCatalogRepository = new CategoriesCatalogRepository(_context!);
                }
                return _categoriesCatalogRepository;
            }
        }
        public ICategoryOptionRepository CategoryOptions {
            get
            {
                if (_categoryOptionRepository == null)
                {
                    _categoryOptionRepository = new CategoryOptionRepository(_context!);
                }
                return _categoryOptionRepository;
            }
        }
        
        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context!.SaveChangesAsync();
        }

    }
}        
