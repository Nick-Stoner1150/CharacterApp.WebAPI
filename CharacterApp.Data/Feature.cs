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

        [ForeignKey(nameof(Character))]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        // public virtual List<Character> Person { get; set; }
    }
}
