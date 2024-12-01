using PawnShop.Context;
using PawnShop.Entities;

namespace PawnShop.Services
{
    public class CustomerService
    {
        private readonly PawnShopContext _context;

        public CustomerService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreateRecord(Customer NewCustomer)
        {
            _context.Customers.Add(NewCustomer);
            _context.SaveChanges();
        }

        public void UpdateRecord(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerByID(int CustomerID)
        {
            return _context.Customers.Find(CustomerID);
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