using PawnShop.Context;
using PawnShop.Entities;

namespace PawnShop.Services
{
    public class JewelryService
    {
        private readonly PawnShopContext _context;

        public JewelryService(PawnShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Jewelry> GetAllJewelries()
        {
            return _context.Jewelries.ToList();
        }

        public Jewelry GetJewelryByID(int id)
        {
            return _context.Jewelries.Find(id);
        }

        public void CreateJewelry(Jewelry item)
        {
            _context.Jewelries.Add(item);
            _context.SaveChanges();
        }

        public void UpdateJewelry(Jewelry jewelry)
        {
            _context.Jewelries.Update(jewelry);
            _context.SaveChanges();
        }

        public void DeleteJewelry(int id)
        {
            var jewelry = _context.Jewelries.Find(id);
            if (jewelry == null)
                throw new Exception("Jewelry not found");

            _context.Jewelries.Remove(jewelry);
            _context.SaveChanges();
        }
    }
}