using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class PlayerModel
    {
        
        public int Number { get; set; }
        [StringLength(12, ErrorMessage = "First name of one of the players is too long")]
        [MinLength(3, ErrorMessage = "First name of one of the players is too short")]
        public string FirstName { get; set; }
        [StringLength(25, ErrorMessage = "Last name of one of the players is too long")]
        [MinLength(3, ErrorMessage = "Last name of one of the players is too short")]
        public string LastName { get; set; }
        public int TeamID { get; set; }
    }
}
