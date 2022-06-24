using System.Collections.Generic;

namespace GameNest.Models
{
    public interface IWishlistRepository
    {
        IList<Wishlist> GetWishlistsByUserId(string userId);

        int GetWishlistCountByGameId(string gameId);

        bool Wishlisted(string userId, string gameId);

        bool AddWishlist(string userId, string gameId);

        bool RemoveWishlist(string userId, string gameId);
    }
}
