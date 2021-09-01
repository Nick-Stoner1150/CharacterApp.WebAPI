using System.ComponentModel.DataAnnotations;

namespace CharacterApp.Models.CharacterModels
{
    public class CharacterCreate
    {
        [Required]
        public string Name { get; set; }
    }
}
