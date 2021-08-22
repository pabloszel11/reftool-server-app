using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace System.ComponentModel.DataAnnotations
{
    public class PlayerListCountAttribute : ValidationAttribute
    {
        protected readonly List<ValidationResult> valResults = new List<ValidationResult>();

        public override bool IsValid(object value)
        {
            var list = value as IEnumerable<PlayerModel>;

            List<ValidationAttribute> valAttributes = new List<ValidationAttribute>();

            int count = 0;

            foreach(var item in list)
            {
                if (item.FirstName != null && item.LastName != null)
                    count++;
            }
            Console.WriteLine(count);            
            return count >= 5;
        }
    }
}
