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
            string sql = "select * from dbo.Players;";

            return this.db.LoadData<PlayerModel, dynamic>(sql, new { });
        }

        public Task<List<PlayerModel>> GetPlayer(string id)
        {
            string sql = String.Format("select * from dbo.Players where ID={0};", id);

            return this.db.LoadData<PlayerModel, dynamic>(sql, new { });
        }

        public Task<List<PlayerModel>> GetPlayersFromTeam(string teamid)
        {
            string sql = String.Format("select * from dbo.Players where TeamID = {0};", teamid);

            return this.db.LoadData<PlayerModel, dynamic>(sql, new { });
        }

        public Task InsertPlayer(PlayerModel player)
        {
            string sql = @"insert into dbo.Players (FirstName, LastName, Number, TeamID)
                          values (@FirstName, @LastName, @Number, @TeamID);";

            return this.db.SaveData(sql, player);
        }
        public Task UpdatePlayer(PlayerModel player)
        {
            string sql = String.Format("update dbo.Players set FirstName = '{0}', LastName = '{1}', Number = {2} where ID = {3};", player.FirstName, player.LastName, player.Number.ToString(), player.ID.ToString());

            return this.db.SaveData(sql, player);
        }

        public Task DeletePlayer(PlayerModel player)
        {
            string sql = String.Format("delete from dbo.Players where ID={0};", player.ID.ToString());

            return this.db.SaveData(sql, player);
        }
    }
}
