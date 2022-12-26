using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}
