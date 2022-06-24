using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GameNest.Models
{
    public class Wishlist
    {
        [Key]
        public string Id { get; set; }

        public string userId { get; set; }

        [ForeignKey("userId")]
        public IdentityUser User { get; set; }


        public string gameId { get; set; }

        [ForeignKey("gameId")]
        public Game Game { get; set; }

       
    }
}
