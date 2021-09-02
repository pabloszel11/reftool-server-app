using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPlayerData
    {
        /// <summary>
        /// Gets all players from DB
        /// </summary>
        /// <returns>List of all players</returns>
        Task<List<PlayerModel>> GetPlayers();
        /// <summary>
        /// Inserts player to DB
        /// </summary>
        /// <param name="player">The object with player data</param>
        /// <returns></returns>
        Task InsertPlayer(PlayerModel player);
        /// <summary>
        /// Updates a player in DB
        /// </summary>
        /// <param name="player">The object with player data</param>
        /// <returns></returns>
        Task UpdatePlayer(PlayerModel player);
        /// <summary>
        /// Deletes player from db
        /// </summary>
        /// <param name="player">The object with player data</param>
        /// <returns></returns>
        Task DeletePlayer(PlayerModel player);
        /// <summary>
        /// Gets list of players from specific team
        /// </summary>
        /// <param name="teamid">Unique team ID</param>
        /// <returns>List of players assigned to the team</returns>
        Task<List<PlayerModel>> GetPlayersFromTeam(string teamid);
        /// <summary>
        /// Gets specific player from DB
        /// </summary>
        /// <param name="id">Unique player ID</param>
        /// <returns>Player with specific ID</returns>
        Task<List<PlayerModel>> GetPlayer(string id);

    }
}