using System;
using MHP.CodingChallenge.Backend.Mapping.Data.DB;
using MHP.CodingChallenge.Backend.Mapping.Data.DB.Blocks;
using MHP.CodingChallenge.Backend.Mapping.Data.DTO;

namespace MHP.CodingChallenge.Backend.Mapping.Data
{
    public class BlockMapper
    {
        public ArticleBlockDto Map(ArticleBlock block)
        {
            //TODO
            return new ArticleBlockDto
            {
                SortIndex = block.SortIndex
             };

        }


    }
}
