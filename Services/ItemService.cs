using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Enums;

namespace PawnShop.Services
{
    public class ItemService
    {
        private readonly PawnShopContext _context;

        public ItemService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreateItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public List<Item> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public Item GetItemById(int itemId)
        {
            return _context.Items.FirstOrDefault(i => i.ItemID == itemId);
        }

        public int GetCustomerIDByItemID(int itemId)
        {
            return _context.Items.FirstOrDefault(i => i.ItemID == itemId).CustomerID;
        }

        public void UpdateRecord(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if (item == null)
                throw new ArgumentException("Item not found.");

            var other = _context.Others.Find(item.OtherID);
            if (other != null)
                _context.Others.Remove(other);

            var jewelry = _context.Jewelries.Find(item.JewelryID);
            if (jewelry != null)
                _context.Jewelries.Remove(jewelry);

            _context.Items.Remove(item);
            _context.SaveChanges();
        }
    }
}