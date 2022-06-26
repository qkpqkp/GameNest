using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GameNest.Models
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAllReviews();

        IEnumerable<ReviewQueryResult> GetReviewsByGameId(string id, string? sortBy);

        bool AddReview(Review review);

     
    }
}
