using System;
using System.Collections.Generic;
using MHP.CodingChallenge.Backend.Mapping.Data.DB;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO;

namespace MHP.CodingChallenge.Backend.Mapping.Data
{
    public class ArticleService
    {
        private ArticleRepository _articleRepository;
        private ArticleMapper _articleMapper;

        public ArticleService(ArticleRepository articleRepository, ArticleMapper articleMapper)
        {
            _articleRepository = articleRepository;
            _articleMapper = articleMapper;
        }

        public List<ArticleDto> GetAll()
        {
            List<ArticleDto> articles = _articleRepository.GetAll()
                .ConvertAll(new Converter<Article, ArticleDto>(_articleMapper.Map));
            // TODO 
            return articles;
        }

        public object GetById(long id)
        {
            Article article = _articleRepository.FindById(id);
            // TODO
            if (article == null) return null;
          
            return _articleMapper.Map(article);
        }

        public object Create(ArticleDto articleDto)
        {
            Article create = _articleMapper.Map(articleDto);
            _articleRepository.Create(create);
            return _articleMapper.Map(create);
        }
    }
}
