using System;
using System.Data;
using Dapper;

namespace QueryPatternExample.Queries
{
    public class GetCategoriesMatchingNameQuery : IQuery<GetCategoriesMatchingNameCriteria, GetCategoriesMatchingNameResult>
    {
        private readonly IDbConnection _dbConnection;

        public GetCategoriesMatchingNameQuery(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public GetCategoriesMatchingNameResult Execute(GetCategoriesMatchingNameCriteria matchingNameCriteria)
        {                        
            string term = "%" + matchingNameCriteria.Name.Replace("%", "[%]").Replace("[", "[[]").Replace("]", "[]]") + "%";

            var result = new GetCategoriesMatchingNameResult
            {
                Categories = _dbConnection.Query<CategoryEntity>(@"select CategoryID, CategoryName, Description from categories where categoryName like @term", new { term })                
            };


            return result;
        }
    }
}