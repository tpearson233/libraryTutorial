using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    public class CheckoutRecordWithItemDetailsDto
    {
        public string CheckoutRecordId { get; set; }
        public string ItemCheckedOutId { get; set; }

        public Tool theItem { get; set; }
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
