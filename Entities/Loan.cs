using PawnShop.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawnShop.Entities
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }

        [Required]
        [ForeignKey("Item")]
        public int ItemID { get; set; }

        [Required]
        public decimal LoanAmount { get; set; }

        [Required]
        public decimal InterestRate { get; set; }

        [Required]
        public DateTime LoanDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public LoanStatus Status { get; set; }

        public virtual Item Item { get; set; }
    }
}

