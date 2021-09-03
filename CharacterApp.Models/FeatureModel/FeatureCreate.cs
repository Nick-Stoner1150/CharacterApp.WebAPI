using System.ComponentModel.DataAnnotations;

namespace CharacterApp.Services.FeatureModel
{
    public class FeatureCreate
    {
        public int CharacterId { get; set; }

        [Required]
        public string SuperPowerName { get; set; }
    }
}
