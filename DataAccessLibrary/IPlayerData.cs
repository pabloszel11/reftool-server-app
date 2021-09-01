using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPlayerData
    {
        Task<List<PlayerModel>> GetPlayers();
        Task InsertPlayer(PlayerModel player);
        Task UpdatePlayer(PlayerModel player);
        Task DeletePlayer(PlayerModel player);
        Task<List<PlayerModel>> GetPlayersFromTeam(string teamid);
        Task<List<PlayerModel>> GetPlayer(string id);

    }
}