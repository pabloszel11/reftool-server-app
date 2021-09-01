using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TeamData : ITeamData
    {
        private readonly ISqlDataAccess db;

        public TeamData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<TeamModel>> GetTeams()
        {
            string sql = "select * from dbo.Teams";

            return this.db.LoadData<TeamModel, dynamic>(sql, new { });
        }
        
        public Task InsertTeam(TeamModel team)
        {
            string sql = @"insert into dbo.Teams (TeamName)
                          values (@TeamName);";

            return this.db.SaveData(sql, team);
        }

        public Task DeleteTeam(TeamModel team)
        {
            string sql = String.Format("delete from dbo.Players where TeamID={0};" +
                                       "delete from dbo.Teams where ID={0};", team.ID.ToString());

            return this.db.SaveData(sql, team);
        }

        public Task<List<TeamModel>> GetTeam(string id)
        {
            string sql = String.Format("select * from dbo.Teams where ID={0};", id);
            return this.db.LoadData<TeamModel, dynamic>(sql, new { });
        }

        public Task<List<TeamModel>> GetTeamID(string teamName)
        {
            string sql = String.Format("select ID from dbo.Teams where TeamName='{0}';", teamName);
            Console.WriteLine(teamName);

            return this.db.LoadData<TeamModel, dynamic>(sql, new {  });
        }
        public Task UpdateTeam(TeamModel team)
        {
            string sql = String.Format("update dbo.Teams set TeamName = '{0}' where ID = {1};", team.TeamName, team.ID.ToString());

            return this.db.SaveData(sql, team);
        }


    }
}
