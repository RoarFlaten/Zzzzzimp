
namespace BL.DTO
{
    public class PaymentData
    {
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public DateTime TransactionTime { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }
    }
}
