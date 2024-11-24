using PawnShop.Context;
using PawnShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PawnShop.Services
{
    public class PaymentService
    {
        private readonly PawnShopContext _context;

        public PaymentService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreatePayment(int loanId, decimal paymentAmount, DateTime paymentDate)
        {
            var payment = new Payment
            {
                LoanID = loanId,
                PaymentAmount = paymentAmount,
                PaymentDate = paymentDate
            };

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

        public void DeletePayment(int paymentId)
        {
            var payment = _context.Payments.Find(paymentId);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }
    }
}