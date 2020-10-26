namespace BooksApi.Models
{
    public class ToolDatabaseSettings : IToolDatabaseSettings
    {
        public string ToolCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IToolDatabaseSettings
    {
        string ToolCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
