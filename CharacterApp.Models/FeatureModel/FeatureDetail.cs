using CharacterApp.Data;
using System;

namespace CharacterApp.Services.FeatureModel
{
    public class FeatureDetail
    {
        public int Id { get; set; }

        public string SuperPowerName { get; set; }

        public Character Character { get; set; }
    }
}
