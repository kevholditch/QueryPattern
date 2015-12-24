namespace QueryPatternExample.Queries
{
    public class CategoryEntity
    {        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("CategoryId: {0}, CategoryName: {1}, Description: {2}", CategoryId, CategoryName, Description);
        }

    }
}