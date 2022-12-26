﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [Required]    
        public double Price { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public double Rating { get; set; }
        public double Discount { get; set; }
    }
}
