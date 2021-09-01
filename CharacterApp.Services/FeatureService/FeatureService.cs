using CharacterApp.Data;
using CharacterApp.Services.FeatureModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterApp.Services.FeatureService
{
    public class FeatureService
    {
        public async Task<bool> Post(FeatureCreate feature)
        {
            var entity = new Feature
            {
                SuperSpeed = feature.SuperSpeed,
                Phasing = feature.Phasing,
                Magic = feature.Magic,
                Flight = feature.Flight,
                Telepathy = feature.Telepathy,
                Healing = feature.Healing,
                Invisibility = feature.Invisibility
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Features.Add(entity);
                return await ctx.SaveChangesAsync() > 0;
            }
        }
    }
}
