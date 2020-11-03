using BooksApi.Models;
using LibraryWebApp.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BooksApi.Services
{
    public class CheckoutService
    {

        private readonly IMongoCollection<CheckoutRecord> _checkout;

        public CheckoutService(ICheckoutDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _checkout = database.GetCollection<CheckoutRecord>(settings.CheckoutCollectionName);
        }

        public List<CheckoutRecord> Get() =>
            _checkout.Find(checkout => true).ToList();

        public CheckoutRecord Get(string id) =>
            _checkout.Find<CheckoutRecord>(checkout => checkout.CheckoutRecordId == id).FirstOrDefault();

        public CheckoutRecord Create(CheckoutRecord checkout)
        {
            _checkout.InsertOne(checkout);
            return checkout;
        }

        public void Update(string id, CheckoutRecord checkoutIn) =>
            _checkout.ReplaceOne(checkout => checkout.CheckoutRecordId == id, checkoutIn);

        public void Remove(CheckoutRecord checkoutIn) =>
            _checkout.DeleteOne(checkout => checkout.CheckoutRecordId == checkoutIn.CheckoutRecordId);

        public void Remove(string id) =>
            _checkout.DeleteOne(checkout => checkout.CheckoutRecordId == id);



        //Verifies if the Tool object already exists by id using Dependency Injection
        /*
        private MyVerify verifyTool;

        public class MyVerify
        {
            public bool ToolService(Tool toolId, CheckoutRecord CheckoutId)
            {
                if (toolId.Equals(CheckoutId))
                {
                    return false;
                }
            }



        }//
        */





    }
}
