using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharacterApp.Data
{
    public class Feature
    {
        public Guid FeatureId { get; set; }

        [Key]
        public int Id { get; set; }

        public string SuperPowerName { get; set; }

        [ForeignKey(nameof(Characters))]
        public int CharacterId { get; set; }

        public Character Characters { get; set; }

        public virtual List<Character> Person { get; set; }
    }
}
