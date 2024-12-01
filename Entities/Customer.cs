using PawnShop.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PawnShop.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string? MiddleName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string PhoneNumber { get; set; }

        [Required]
        public IdentificationType IdentificationType { get; set; }

        [Required]
        [StringLength(100)]
        public string IdentificationNumber { get; set; }

        public ICollection<Item> Items { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}