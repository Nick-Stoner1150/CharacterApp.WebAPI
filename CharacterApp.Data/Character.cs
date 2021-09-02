using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterApp.Data
{
    public class Character
    {
        public Guid OwnerId { get; set; }

        [Key]
        public int CharacterId { get; set; }

        [Required]
        public string Name { get; set; }
        public Team Team { get; set; }
        public List<Feature> Features { get; set; } = new List<Feature>();
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
    }
}
