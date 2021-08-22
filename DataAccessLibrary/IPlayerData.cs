using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPlayerData
    {
        Task<List<PlayerModel>> GetPlayers();
        Task InsertPlayer(PlayerModel player);
        Task<List<PlayerModel>> GetPlayersFromTeam(string teamid);
    }
}