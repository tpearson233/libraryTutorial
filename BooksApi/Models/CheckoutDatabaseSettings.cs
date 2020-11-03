namespace BooksApi.Models
{
    public class CheckoutDatabaseSettings : ICheckoutDatabaseSettings
    {
        public string CheckoutCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ICheckoutDatabaseSettings
    {
        string CheckoutCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}