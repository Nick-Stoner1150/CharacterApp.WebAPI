using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
