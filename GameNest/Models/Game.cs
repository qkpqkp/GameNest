using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameNest.Models
{
    public class Game
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }   

        public string Description { get; set; }

        public string LongDescription { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }

        public string ImageURL { get; set; }

        public decimal Score { get; set; }
    }
}
