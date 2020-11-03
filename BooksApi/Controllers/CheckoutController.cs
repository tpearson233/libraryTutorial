using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController:ControllerBase
    {
        private readonly CheckoutService _checkoutService;

        public CheckoutController(CheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }


       /*These service endpoints were to be collected and query into the different ActionResults.
        * 
        * 
        [HttpGet] 
        public ActionResult <List<CheckoutRecord>> Get() => _checkoutService.Get();
        [HttpGet][Route("details")] public IActionResult GetAllCheckoutRecordsWithItemDetails()  
        [HttpGet][Route("open")] public IActionResult GetAllOpenCheckoutRecordsWithItemDetails()  
        [HttpGet("{id}", Name = "CheckoutRecordById")] public IActionResult GetCheckoutRecordById(string id)
        [HttpPost] public IActionResult CreateCheckoutRecord([FromBody] CheckoutRecordForCreationDto checkoutRecordForCreation)
        [HttpPut("{id}")] public IActionResult UpdateCheckoutRecord(string id, [FromBody] CheckoutRecordForCheckInUpdateDto checkoutRecordForUpdate

        */






    }
}
