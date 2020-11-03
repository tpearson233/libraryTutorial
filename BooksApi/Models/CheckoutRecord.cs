
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

//change the namespace to fit your project
namespace LibraryWebApp.Models
{
    public class CheckoutRecord
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        //you may or may not need the following attribute - double check
        [BsonElement("_id")]
        public string CheckoutRecordId { get; set; }
        public string ItemCheckedOutId { get; set; }
        //replace ILibraryItem with your item type
        public string item { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateReturned { get; set; }
        public decimal AgreedDailyCost { get; set; }
        public decimal AmountPaid { get; set; }
        public Boolean HasBeenReturned { get; set; }

        public override String ToString() =>
        $"Checkout record id: {CheckoutRecordId}\nItem checked out id {ItemCheckedOutId}";

    }
}