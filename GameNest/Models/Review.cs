using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GameNest.Models
{
    public class Review
    {
        [Key]
        public string Id { get; set; }

        public string Message { get; set; }

        public DateTime CreateDateUTC { get; set; }


        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser User { get; set; }

        public string UserName { get; set; }

        public string GameId { get; set; }

        [ForeignKey("GameId")]
        public Game Game { get; set; }
       

        public int Score { get; set; }
    }
}
