using PawnShop.Context;
using PawnShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PawnShop.Services
{
    public class CustomerService
    {
        private readonly PawnShopContext _context;

        public CustomerService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreateRecord(string firstName, string middleName, string lastName, string address, string email, string phoneNumber)
        {
            var customer = new Customer
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Address = address,
                Email = email,
                PhoneNumber = phoneNumber
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public void DeleteRecordById(int customerId)
        {
            var customer = _context.Customers.Find(customerId);

            if (customer == null)
                throw new ArgumentException("Customer not found.");

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}