using CharacterApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterApp.Models.CharacterModels
{
    public class CharacterDetail
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        // public List<Feature> Features { get; set; }
        public string TeamName { get; set; }
    }
}
