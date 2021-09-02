using CharacterApp.Data;
using CharacterApp.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace CharacterApp.Services.CharacterServices
{
    public class CharacterServices
    {
        private readonly Guid _userId;

        public CharacterServices(Guid userId)
        {
            _userId = userId;
        }

        public async Task<bool> Post(CharacterCreate character)
        {
            var entity = new Character
            {
                Name = character.Name,
                TeamId = character.TeamId,
                CreatedDate = DateTime.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                var team = await ctx.Teams.FindAsync(character.TeamId);
                if (team is null)
                    return false;

                entity.Team = team;
                entity.Team.Characters.Add(entity);

                ctx.Characters.Add(entity);
                return await ctx.SaveChangesAsync() > 0;
            }
        }

        public async Task<IEnumerable<CharacterListItem>> Get()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    await
                    ctx
                    .Characters
                    .Select(c => new CharacterListItem
                    {
                        CharacterId = c.CharacterId,
                        Name = c.Name,
                        TeamName = c.Team.TeamName
                    }).ToListAsync();

                return query;
            }
        }

        public async Task<CharacterDetail> Get(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var character =
                    await
                    ctx
                    .Characters
                    .SingleOrDefaultAsync(c => c.CharacterId == id);

                if (character is null)
                    return null;

                return new CharacterDetail
                {
                    CharacterId = character.CharacterId,
                    Name = character.Name,
                    CreatedDate = character.CreatedDate,
                    ModifiedDate = character.ModifiedDate,
                    TeamName = character.Team.TeamName
                };
            }
        }
    }
}
