using PawnShop.Context;
using PawnShop.Entities;

namespace PawnShop.Services
{
    public class OtherService
    {
        private readonly PawnShopContext _context;

        public OtherService(PawnShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Other> GetAllOthers()
        {
            return _context.Others.ToList();
        }

        public Other GetOtherByID(int id)
        {
            return _context.Others.Find(id);
        }

        public void CreateOther(Other item)
        {
            _context.Others.Add(item);
            _context.SaveChanges();
        }

        public void UpdateOther(Other other)
        {
            _context.Others.Update(other);
            _context.SaveChanges();
        }

        public void DeleteOther(int id)
        {
            var other = _context.Others.Find(id);
            if (other == null)
                throw new Exception("Item not found.");

            _context.Others.Remove(other);
            _context.SaveChanges();
        }
    }
}