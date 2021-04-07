using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessPayment.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentProcessId { get; set; }

        
        [Column(TypeName ="nvarchar(16)")]
        public string CreditCardNumber { get; set; }
        
        [Column(TypeName = "nvarchar(16)")]
        public string CardHolder { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }


    }
}
