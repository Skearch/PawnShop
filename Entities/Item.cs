using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawnShop.Entities
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public decimal EstimatedValue { get; set; }

        [Required]
        public DateTime PawnDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
