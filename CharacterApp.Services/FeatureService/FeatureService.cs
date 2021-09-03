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
                       CharacterId = f.CharacterId,
                       SuperPowerName = f.SuperPowerName
                    }).ToListAsync();

                return query;
            }
        }
        public async Task<bool> Post(FeatureCreate feature)
        {
            var entity = new Feature
            {
                CharacterId = feature.CharacterId,
                SuperPowerName = feature.SuperPowerName
            };

            using (var ctx = new ApplicationDbContext())
            {
                var character = await ctx.Characters.FindAsync(feature.CharacterId);
                if (character is null)
                {
                    return false;
                }

                entity.Characters = character;
                entity.Characters.Features.Add(entity);

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
                oldData.SuperPowerName = featureEdit.SuperPowerName;
                return await ctx.SaveChangesAsync() > 0;
            }
        }
    }
}
