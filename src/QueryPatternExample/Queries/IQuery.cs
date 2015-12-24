namespace QueryPatternExample.Queries
{
    public interface IQuery<in TCriteria, out TResult>
    {
        TResult Execute(TCriteria criteria);
    }
}