using System.Collections;
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

        public IEnumerable<ReviewQueryResult> GetReviewsByGameId(string id, string? sortBy)
        {
            var query = from review in _context.Reviews
                        join user in _context.Users
                        on review.UserId equals user.Id
                        select new ReviewQueryResult()
                        {
                            review = review,
                            userName = user.UserName,
                        };
           
            if (sortBy == null) { 
                return query;
            }else if(sortBy == "top")
            {
                return query.OrderByDescending(n => n.review.Score);
            }
            else
            {
                return query.OrderByDescending(n => n.review.CreateDateUTC);
            }
        }

    }
}
