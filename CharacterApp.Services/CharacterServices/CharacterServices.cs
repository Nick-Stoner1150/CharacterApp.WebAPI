using CharacterApp.Data;
using CharacterApp.Models.CharacterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                CreatedDate = DateTime.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return await ctx.SaveChangesAsync() > 0;
            }
        }
    }
}
