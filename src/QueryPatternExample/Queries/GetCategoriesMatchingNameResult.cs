using System.Collections.Generic;

namespace QueryPatternExample.Queries
{
    public class GetCategoriesMatchingNameResult
    {
        public IEnumerable<CategoryEntity> Categories { get; set; }
    }
}