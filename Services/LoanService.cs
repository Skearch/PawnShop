using Microsoft.EntityFrameworkCore;
using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PawnShop.Services
{
    public class LoanService
    {
        private readonly PawnShopContext _context;

        public LoanService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreateLoan(int itemId, decimal loanAmount, decimal interestRate, DateTime loanDate, DateTime dueDate, LoanStatus status)
        {
            var loan = new Loan
            {
                ItemID = itemId,
                LoanAmount = loanAmount,
                InterestRate = interestRate,
                LoanDate = loanDate,
                DueDate = dueDate,
                Status = status
            };

            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public List<Loan> GetAllLoans()
        {
            return _context.Loans.Include(l => l.Item).ToList();
        }

        public Loan GetLoanById(int loanId)
        {
            return _context.Loans.Include(l => l.Item).FirstOrDefault(l => l.LoanID == loanId);
        }

        public void UpdateLoan(int loanId, decimal loanAmount, decimal interestRate, DateTime dueDate, LoanStatus status)
        {
            var loan = _context.Loans.Find(loanId);
            if (loan != null)
            {
                loan.LoanAmount = loanAmount;
                loan.InterestRate = interestRate;
                loan.DueDate = dueDate;
                loan.Status = status;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Loan not found.");
            }
        }

        public void DeleteLoan(int loanId)
        {
            var loan = _context.Loans.Find(loanId);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Loan not found.");
            }
        }
    }
}