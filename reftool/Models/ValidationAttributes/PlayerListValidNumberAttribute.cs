using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace System.ComponentModel.DataAnnotations
{
    public class PlayerListValidNumberAttribute : ValidationAttribute
    {
        protected readonly List<ValidationResult> valResults = new List<ValidationResult>();

        public override bool IsValid(object value)
        {
            var list = value as IEnumerable<PlayerModel>;

            List<ValidationAttribute> valAttributes = new List<ValidationAttribute>();

            List<int> numbers = new List<int>();

            foreach(var item in list)
            {
                if (item.Number < 0 || item.Number > 99)
                    return false;
            }
            return true;
        }
    }
}
