using BL;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BL.DTO;

namespace testPayments.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        public PaymentManager Manager { get; set; }
        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
            var provider = new Vipps();
            //maybe set provider elsewhere
            Manager = new PaymentManager(provider);
        }

       [HttpGet] 
        [Route("[controller]/ValidateAccount")]
        public bool ValidateAccount(string accountNumber)
        {
            return Manager.ValidateAccountNumber(accountNumber);
        }

        [HttpGet]
        [Route("[controller]/GetAccountBalance")]
        public int GetAccountBalance(string accountNumber)
        {
            return 1000000;
        }
        [HttpGet]
        [Route("[controller]/GetTransactionReceipt")]
        public string GetTransactionReceipt(string transactionId)
        {
            //TODO: look up transaction in db and return a transactionObject
            return "OK";
        }

        [HttpPost]
        [Route("[controller]/MakePayment")]
        public bool MakePayment(PaymentData paymentData)
        {
            return Manager.ProcessPayment(paymentData);
        }


        private readonly ILogger<PaymentController> _logger;



    }

}
