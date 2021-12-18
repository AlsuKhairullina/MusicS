using System;
using System.ComponentModel.DataAnnotations;

namespace MusicS.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [DataType(DataType.ImageUrl)]
        
        public string ImageUrl { get; set; }
        public Categories Category { get; set; }
    }
    
    public enum Categories
    {
        Гитары,
        Клавишные,
        Аксессуары
    }
}