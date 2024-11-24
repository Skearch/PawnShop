using Microsoft.EntityFrameworkCore;
using PawnShop.Context;
using PawnShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PawnShop.Services
{
    public class ItemService
    {
        private readonly PawnShopContext _context;

        public ItemService(PawnShopContext context)
        {
            _context = context;
        }

        public void CreateItem(int customerId, string itemName, string description, decimal estimatedValue, DateTime pawnDate)
        {
            var item = new Item
            {
                CustomerID = customerId,
                ItemName = itemName,
                Description = description,
                EstimatedValue = estimatedValue,
                PawnDate = pawnDate
            };

            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public List<Item> GetAllItems()
        {
            return _context.Items.Include(i => i.Customer).ToList();
        }

        public Item GetItemById(int itemId)
        {
            return _context.Items.Include(i => i.Customer).FirstOrDefault(i => i.ItemID == itemId);
        }

        public void UpdateItem(int itemId, string itemName, string description, decimal estimatedValue, DateTime pawnDate)
        {
            var item = _context.Items.Find(itemId);
            if (item != null)
            {
                item.ItemName = itemName;
                item.Description = description;
                item.EstimatedValue = estimatedValue;
                item.PawnDate = pawnDate;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Item not found.");
            }
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Item not found.");
            }
        }
    }
}