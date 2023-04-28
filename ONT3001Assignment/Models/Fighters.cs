using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;
namespace ONT3001Assignment.Models
{
    public class Fighters
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BenderName { get; set; }
        [Required]
        public string Origins { get; set;}
        [Required] 
        public string Age { get;set; }
        [Required]
        public string Ability { get; set; }
    }
}
