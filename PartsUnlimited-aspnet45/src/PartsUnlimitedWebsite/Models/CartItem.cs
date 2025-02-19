﻿using System;
using System.ComponentModel.DataAnnotations;
// first change 
//hello world
namespace PartsUnlimited.Models
{
    public class CartItem : ILineItem
    {
        [Key]
        public int CartItemId { get; set; }
//my second change
        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}