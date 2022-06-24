using System;
using System.Collections.Generic;
using System.Linq;

namespace GameNest.Models
{
    public class WishlistRepository : IWishlistRepository
    {
        private AppDbContext _context;

        public WishlistRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public int GetWishlistCountByGameId(string gameId)
        {
            return _context.Wishlist.Count(n => n.gameId == gameId);
        }

        public IList<Wishlist> GetWishlistsByUserId(string userId)
        {
            return _context.Wishlist.Where(n => n.userId == userId).ToList();
        }

        public bool Wishlisted(string userId, string gameId)
        {
            return _context.Wishlist.Any(n => n.userId == userId && n.gameId == gameId);
        }

        public bool AddWishlist(string userId, string gameId)
        {
            if (!_context.Wishlist.Any(n => n.userId == userId && n.gameId == gameId))
            {
                Wishlist wishlsit = new Wishlist();
                wishlsit.Id = Guid.NewGuid().ToString();
                wishlsit.userId = userId;
                wishlsit.gameId = gameId;
                _context.Wishlist.Add(wishlsit);
            }
            int changes = _context.SaveChanges();
            return changes > 0;
        }

        public bool RemoveWishlist(string userId, string gameId)
        {
            if (_context.Wishlist.Any(n => n.userId == userId && n.gameId == gameId))
            {
                _context.Wishlist.RemoveRange(_context.Wishlist.Where(n => n.userId == userId && n.gameId == gameId));
            }
            int changes = _context.SaveChanges();
            return changes > 0;
        }
    }
}
