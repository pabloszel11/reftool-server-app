using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class TeamModel
    {
        public int ID { get; set; }
        public string TeamName { get; set; }

        public List<PlayerModel> TeamPlayers { get; set; }
    }
}
