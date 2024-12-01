using Microsoft.EntityFrameworkCore;
using PawnShop.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawnShop.Entities
{
    [Index(nameof(ItemName), IsUnique = true)]
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required]
        [ForeignKey("Other")]
        public int OtherID { get; set; }

        [Required]
        [ForeignKey("Jewelry")]
        public int JewelryID { get; set; }

        [Required]
        public ItemType ItemType { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        public decimal ItemValue { get; set; }

        [Required]
        public DateTime PawnDate { get; set; }

        [Required]
        public bool IsSold { get; set; }

        [Required]
        public bool IsRedeemed { get; set; }

        public Customer Customer { get; set; }
        public Other Other { get; set; }
        public Jewelry Jewelry { get; set; }
        public Loan Loan { get; set; }
    }
}