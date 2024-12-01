using PawnShop.Context;
using PawnShop.Entities;

namespace PawnShop.Services
{
    public class LoanService
    {
        private readonly PawnShopContext _context;

        public LoanService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreateLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public List<Loan> GetAllLoans()
        {
            return _context.Loans.ToList();
        }

        public Loan GetLoanById(int loanId)
        {
            return _context.Loans.FirstOrDefault(l => l.LoanID == loanId);
        }

        public void UpdateRecord(Loan loan)
        {
            _context.Loans.Update(loan);
            _context.SaveChanges();
        }

        public void DeleteLoan(int loanId)
        {
            var loan = _context.Loans.Find(loanId);
            if (loan == null)
                throw new ArgumentException("Loan not found.");

            _context.Loans.Remove(loan);
            _context.SaveChanges();
        }
    }
}