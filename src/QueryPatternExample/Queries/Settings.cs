using System.Configuration;

namespace QueryPatternExample.Queries
{
    public class Settings : ISettings
    {        

        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["Default"].ConnectionString; }
        }
    }
}