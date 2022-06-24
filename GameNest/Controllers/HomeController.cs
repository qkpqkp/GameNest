using System;
using System.Collections.Generic;
using GameNest.Models;
using GameNest.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GameNest.Controllers
{
    public class HomeController : Controller
    {
        private IGameRepository _gameRepository;
        private IReviewRepository _reviewRepository;
    
        public HomeController(IGameRepository gameRepository,IReviewRepository reviewRepository)
        {
            _gameRepository = gameRepository;
            _reviewRepository = reviewRepository;
        }
        public IActionResult Index()
        {
            return View(_gameRepository.GetTopGames(10));
        }

        
    }
}
