using BL.Interfaces;
using BL.DTO;


namespace BL
{
    public class PaymentManager
    {
        IPaymentProvider paymentProvider;
        public PaymentManager(IPaymentProvider provider) 
        {
            paymentProvider = provider;
        }

        public bool ProcessPayment(PaymentData paymentData)
        {
            
            //PaymentProcessor.ProcessPayment();
            //todo: refactor this to return an object with metadata
            return true;
        }

        public new bool ValidateAccountNumber(string accountNumber)
        {

            //TODO: add some reg exp or look up something from db here
            return true;
        }
    }
}
