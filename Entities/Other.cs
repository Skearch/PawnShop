using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PawnShop.Entities
{
    public class Other
    {
        [Key]
        public int OtherID { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}