using System;
using System.Collections.Generic;
using GameNest.Models;
using GameNest.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace GameNest.Controllers
{
    public class DetailController : Controller
    {
        private IGameRepository _gameRepository;
        private IReviewRepository _reviewRepository;
        private IWishlistRepository _wishlistRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public DetailController(IGameRepository gameRepository, IReviewRepository reviewRepository, IWishlistRepository wishlistRepository, UserManager<IdentityUser> userManager)
        {
            _gameRepository = gameRepository;
            _reviewRepository = reviewRepository;
            _wishlistRepository = wishlistRepository;
            _userManager = userManager;
        }
        public IActionResult Index(string id, string? sortBy)
        {
            var detailViewModel = new DetailViewModel()
            {
                game = _gameRepository.GetGameById(id),
                reviews = _reviewRepository.GetReviewsByGameId(id, sortBy), 
                wishlisted = _wishlistRepository.Wishlisted(_userManager.GetUserId(this.User),id),
                user = _userManager.GetUserAsync(this.User).Result,
            };
            return View(detailViewModel);
        }

        [Authorize]
        [HttpPost]
        public IActionResult SubmitReview(string score, string review, string gameId, string userId)
        {
            Review newReview = new Review();
            newReview.Id = Guid.NewGuid().ToString();
            newReview.Score = int.Parse(score);
            newReview.Message = review;
            newReview.GameId = gameId;
            newReview.UserId = userId;
            newReview.CreateDateUTC = DateTime.Now;
            if (_reviewRepository.AddReview(newReview))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult ToggleWishlisted(bool wishlisted,string userId, string gameId)
        {
            bool succeed = false;
            if (wishlisted)
            {
                succeed = _wishlistRepository.RemoveWishlist(userId, gameId);
            }
            else
            {
                succeed = _wishlistRepository.AddWishlist(userId, gameId);
            }
            return Ok(succeed);
        }
    }
}
