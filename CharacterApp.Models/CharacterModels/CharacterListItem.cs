using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterApp.Models.CharacterModels
{
    public class CharacterListItem
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        // public List<Feature> Features { get; set; }
        public string TeamName { get; set; }
    }
}
