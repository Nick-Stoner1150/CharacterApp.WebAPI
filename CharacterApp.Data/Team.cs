using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterApp.Data
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        public string TeamName { get; set; }

        public virtual List<Character> Characters { get; set; }

    }
}
