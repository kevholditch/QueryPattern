namespace QueryPatternExample.Queries
{
    public interface IQueryExecutor
    {
        TResult Execute<TCriteria, TResult>(TCriteria criteria);
    }
}