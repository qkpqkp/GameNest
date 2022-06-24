using System.Collections.Generic;
using System.Linq;

namespace GameNest.Models
{
    public class ReviewRepository : IReviewRepository
    {
        private AppDbContext _context;

        public ReviewRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public bool AddReview(Review review)
        {
            int count = _context.Reviews.Count(n => n.GameId == review.GameId);
            _context.Reviews.Add(review);
            Game game = _context.Games.FirstOrDefault(n => n.Id == review.GameId);
            game.Score = (game.Score * count + review.Score) / (count + 1);
            _context.Games.Update(game);
            int changes = _context.SaveChanges();
            return changes > 0;
        }

        public IEnumerable<Review> GetAllReviews()
        {
            return _context.Reviews;
        }

        public IList<Review> GetReviewsByGameId(string id, string? sortBy)
        {
            IEnumerable<Review> reviews = _context.Reviews.Where(n => n.GameId == id);
            if (sortBy == null) { 
                return reviews.ToList();
            }else if(sortBy == "top")
            {
                return reviews.OrderByDescending(n => n.Score).ToList();
            }
            else
            {
                return reviews.OrderByDescending(n => n.CreateDateUTC).ToList();
            }
        }

    }
}
