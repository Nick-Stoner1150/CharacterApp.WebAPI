using CharacterApp.Data;
using CharacterApp.Services.FeatureModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterApp.Services.FeatureService
{
    public class FeatureService
    {
        private readonly Guid _featureId;
        public FeatureService(Guid featureId)
        {
            _featureId = featureId;
        }

        public async Task<IEnumerable<FeatureListDetail>> Get()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    await
                    ctx
                    .Features
                    .Select(f => new FeatureListDetail
                    {
                        SuperSpeed = f.SuperSpeed,
                        Phasing = f.Phasing,
                        Magic = f.Magic,
                        Flight = f.Flight,
                        Telepathy = f.Telepathy,
                        Healing = f.Healing,
                        Invisibility = f.Invisibility
                    }).ToListAsync();

                return query;
            }
        }
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

        public async Task<bool> Put(FeatureEdit featureEdit, int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var oldData = await ctx.Features.FindAsync(id);
                if (oldData is null)
                {
                    return false;
                }
                oldData.SuperSpeed = featureEdit.SuperSpeed;
                oldData.Phasing = featureEdit.Phasing;
                oldData.Magic = featureEdit.Magic;
                oldData.Flight = featureEdit.Flight;
                oldData.Telepathy = featureEdit.Telepathy;
                oldData.Healing = featureEdit.Healing;
                oldData.Invisibility = featureEdit.Invisibility;

                return await ctx.SaveChangesAsync() > 0;
            }
        }
    }
}
