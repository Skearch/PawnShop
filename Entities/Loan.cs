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
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required]
        public decimal LoanAmount { get; set; }

        [Required]
        public decimal ProcessingFee { get; set; }

        [Required]
        public decimal Interest { get; set; }

        [Required]
        public DateTime LoanDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public DateTime? RepaymentDate { get; set; }

        public Item Item { get; set; }
        public Customer Customer { get; set; }
    }
}