using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterApp.Data
{
    class Feature
    {
        [Key]
        public int Id { get; set; }

        public List<Ability> Abilities { get; set; }

        [ForeignKey(nameof(Characters))]
        public Character Characters { get; set; }
    }
}
