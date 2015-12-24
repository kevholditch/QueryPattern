namespace QueryPatternExample.Queries
{
    public interface IQueryFactory
    {
        IQuery<TCriteria, TResult> Create<TCriteria, TResult>();
    }
}