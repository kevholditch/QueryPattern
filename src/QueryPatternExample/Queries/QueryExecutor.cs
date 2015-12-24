namespace QueryPatternExample.Queries
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly IQueryFactory _queryFactory;

        public QueryExecutor(IQueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }

        public TResult Execute<TCriteria, TResult>(TCriteria criteria)
        {
            return _queryFactory.Create<TCriteria, TResult>().Execute(criteria);
        }
    }
}