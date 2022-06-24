using System.Collections.Generic;
using System.Linq;
namespace GameNest.Models
{
    public class GameRepository : IGameRepository
    {
        private AppDbContext _context;

        public GameRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IEnumerable<Game> GetAllGames()
        {
            return _context.Games;
        }

        public Game GetGameById(string id)
        {
            return _context.Games.FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<Game> GetTopGames(int count)
        {
            return _context.Games.OrderByDescending(n => n.Score).Take(count);
        }
    }
}
