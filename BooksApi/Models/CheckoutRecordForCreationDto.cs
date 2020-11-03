using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    public class CheckoutRecordForCreationDto
    {
        public string ItemCheckedOutId { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public DateTime DateDue { get; set; }
        public Decimal AgreedDailyCost { get; set; }
    }
}
