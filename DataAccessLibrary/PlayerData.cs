using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PlayerData : IPlayerData
    {
        private readonly ISqlDataAccess db;

        public PlayerData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<PlayerModel>> GetPlayers()
        {
            string sql = "select * from dbo.Players";

            return this.db.LoadData<PlayerModel, dynamic>(sql, new { });
        }

        public Task<List<PlayerModel>> GetPlayersFromTeam(string teamid)
        {
            string sql = String.Format("select * from dbo.Players where TeamID = {0}", teamid);

            return this.db.LoadData<PlayerModel, dynamic>(sql, new { });
        }

        public Task InsertPlayer(PlayerModel player)
        {
            string sql = @"insert into dbo.Players (FirstName, LastName, Number, TeamID)
                          values (@FirstName, @LastName, @Number, @TeamID);";

            return this.db.SaveData(sql, player);
        }
    }
}
