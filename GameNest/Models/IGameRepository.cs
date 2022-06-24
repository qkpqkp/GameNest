using System.Collections.Generic;

namespace GameNest.Models
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAllGames();

        Game GetGameById(string id);

        IEnumerable<Game> GetTopGames(int count);
    }
}
