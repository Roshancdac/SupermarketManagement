﻿using System.ComponentModel.DataAnnotations;


namespace CoreBusniess
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
