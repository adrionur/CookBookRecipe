using System;
using System.ComponentModel.DataAnnotations;
using static CookBookRecipe.Utils.Enums;

namespace CookBookRecipe.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public UserType Type { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime LastLoginTime { get; set; }
    }
}
