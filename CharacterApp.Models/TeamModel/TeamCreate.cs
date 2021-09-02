using System.ComponentModel.DataAnnotations;

namespace CharacterApp.Models.TeamModel
{
    public class TeamCreate
    { 

        [Required]
        public string TeamName { get; set; }
    }
}
