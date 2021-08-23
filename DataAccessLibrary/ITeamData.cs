using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITeamData
    {
        Task<List<TeamModel>> GetTeamID(string teamName);
        Task<List<TeamModel>> GetTeam(string id);
        Task<List<TeamModel>> GetTeams();
        Task InsertTeam(TeamModel player);
    }
}