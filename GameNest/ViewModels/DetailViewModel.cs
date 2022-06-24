using System.Collections.Generic;
using GameNest.Models;
using Microsoft.AspNetCore.Identity;

namespace GameNest.ViewModels
{
    public class DetailViewModel
    {
        public Game game { get; set; }

        public IList<Review> reviews { get; set; }

        public bool wishlisted { get; set; }
        public IdentityUser user { get; set; }
    }
}
