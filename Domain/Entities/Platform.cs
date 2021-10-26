using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class Platform
    {
        
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int ExternelID { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Command> Command { get; set; } = new List<Command>();
    }
}