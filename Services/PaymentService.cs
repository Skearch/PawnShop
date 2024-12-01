using PawnShop.Context;
using PawnShop.Entities;

namespace PawnShop.Services
{
    public class PaymentService
    {
        private readonly PawnShopContext _context;

        public PaymentService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreatePayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public List<Payment> GetAllPayments()
        {
            return _context.Payments.ToList();
        }

        public List<Payment> GetPaymentsByLoanId(int loanId)
        {
            return _context.Payments.Where(p => p.LoanID == loanId).ToList();
        }

        public Payment GetPaymentsById(int PaymentID)
        {
            return _context.Payments.Find(PaymentID);
        }

        public void UpdateRecord(Payment payment)
        {
            _context.Payments.Update(payment);
            _context.SaveChanges();
        }

        public void DeletePayment(int paymentId)
        {
            var payment = _context.Payments.Find(paymentId);
            if (payment ==null)
                throw new Exception("Payment not found.");

            _context.Payments.Remove(payment);
            _context.SaveChanges();
        }
    }
}