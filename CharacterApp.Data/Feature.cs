using System;
using System.ComponentModel.DataAnnotations;

namespace CharacterApp.Data
{
    public class Feature
    {
        public Guid FeatureId { get; set; }

        [Key]
        public int Id { get; set; }

        public string SuperSpeed { get; set; }

        public string Phasing { get; set; }

        public string Magic { get; set; }

        public string Flight { get; set; }

        public string Telepathy { get; set; }

        public string Healing { get; set; }

        public string Invisibility { get; set; }
    }
}
