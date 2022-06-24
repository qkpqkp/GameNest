using System.Collections.Generic;

namespace GameNest.Models
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAllReviews();

        IList<Review> GetReviewsByGameId(string id,string? sortBy);

        bool AddReview(Review review);

     
    }
}
