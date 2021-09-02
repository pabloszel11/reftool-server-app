using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITeamData
    {
        /// <summary>
        /// Gets the team ID based on its name
        /// </summary>
        /// <param name="teamName">Name of the team</param>
        /// <returns>Unique ID of the team</returns>
        Task<List<TeamModel>> GetTeamID(string teamName);
        /// <summary>
        /// Gets the team based on ID
        /// </summary>
        /// <param name="id">Unique ID</param>
        /// <returns>Team model</returns>
        Task<List<TeamModel>> GetTeam(string id);
        /// <summary>
        /// Gets all teams
        /// </summary>
        /// <returns>List of all teams</returns>
        Task<List<TeamModel>> GetTeams();
        /// <summary>
        /// Inserts a team to DB
        /// </summary>
        /// <param name="team">Object representing the team</param>
        /// <returns></returns>
        Task InsertTeam(TeamModel team);
        /// <summary>
        /// Updates the team in DB
        /// </summary>
        /// <param name="team">Object representing the team</param>
        /// <returns></returns>
        Task UpdateTeam(TeamModel team);
        /// <summary>
        /// Deletes team from DB
        /// </summary>
        /// <param name="team">Object representing the team</param>
        /// <returns></returns>
        Task DeleteTeam(TeamModel team);
    }
}