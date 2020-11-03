using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models
{
    public class CheckoutRecordForCheckInUpdateDto
    {
        public DateTime DateReturned { get; set; }
        public Decimal AmountPaid { get; set; }
    }
}
