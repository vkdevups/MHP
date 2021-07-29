using System;
namespace MHP.CodingChallenge.Backend.Mapping.Data.DTO
{
    public class ArticleBlockDto : IEquatable<ArticleBlockDto>, IComparable<ArticleBlockDto>
    {
        public int SortIndex { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            ArticleBlockDto objAsPart = obj as ArticleBlockDto;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        // Default comparer for Part type.
        public int CompareTo(ArticleBlockDto comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.SortIndex.CompareTo(comparePart.SortIndex);
        }
        public override int GetHashCode()
        {
            return SortIndex;
        }
        public bool Equals(ArticleBlockDto other)
        {
            if (other == null) return false;
            return (this.SortIndex.Equals(other.SortIndex));
        }
    }
}
