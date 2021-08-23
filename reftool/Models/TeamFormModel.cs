using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reftool_blazor_server.Models
{
    class TeamFormModel
    {
        public List<TeamModel> CurrentTeams;

        [Required]
        [StringLength(35, ErrorMessage = "Team name is too long")]
        [MinLength(3, ErrorMessage = "Team name is too short")]
        public string TeamName { get; set; }
        
        [PlayerListCountAttribute(ErrorMessage = "Not enough players (at least 5)")]
        [PlayerListDuplicateNo(ErrorMessage = "There are duplicate numbers in the team")]
        [PlayerListValidNumber(ErrorMessage = "Some numbers are not valid (must be between 0 and 99 inclusive)")]
        public List<PlayerModel> Players { get; set; }

        public TeamFormModel()
        {
            PlayerModel p = new PlayerModel();
            this.Players = new List<PlayerModel>();
            for(int i = 0; i < 12; i++)
            {
                this.Players.Add(new PlayerModel());
            }
        }
    }
}
