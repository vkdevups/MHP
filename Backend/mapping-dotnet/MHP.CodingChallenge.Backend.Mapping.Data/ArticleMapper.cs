using System;
using System.Collections.Generic;
using MHP.CodingChallenge.Backend.Mapping.Data.DB;
using MHP.CodingChallenge.Backend.Mapping.Data.DB.Blocks;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO;

namespace MHP.CodingChallenge.Backend.Mapping.Data
{
    public class ArticleMapper
    {

        private BlockMapper _blockMapper;

        public ArticleDto Map(Article article)
        {
            _blockMapper = new BlockMapper();

            Func<HashSet<ArticleBlock>,List<ArticleBlockDto>> map2Block = (x) =>
            {
                var RetList = new List<ArticleBlockDto>();
                var en = x.GetEnumerator();
                while (en.MoveNext())
                {
                    RetList.Add(_blockMapper.Map(en.Current));
                }
                RetList.Sort();

                return RetList;
            }
          
            ;

            //TODO
            return new ArticleDto {
                Id = article.Id,
                Author = article.Author,
                Title = article.Title,
                Description = article.Description,
                Blocks = map2Block(article.Blocks)
            };
           
        }

        public Article Map(ArticleDto articleDto)
        {
            // Nicht Teil dieser Challenge.
            return new Article();
        }
    }
}
