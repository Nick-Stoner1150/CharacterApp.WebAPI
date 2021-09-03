using System.ComponentModel.DataAnnotations;

namespace CharacterApp.Services.FeatureModel
{
    public class FeatureCreate
    {
        [Required]
        public string SuperPowerName { get; set; }
    }
}
