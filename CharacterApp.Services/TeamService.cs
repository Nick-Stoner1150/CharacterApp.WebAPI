using CharacterApp.Data;
using CharacterApp.Models.TeamModel;
using System;
using System.Linq;

namespace CharacterApp.Services
{
    public class TeamService
    {
        private readonly Guid _userId;

        public TeamService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTeam(TeamCreate model)
        {
            var entity =
                new Team()
                {
                    TeamId = model.TeamId,
                    TeamName = model.TeamName,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }


        }

        public bool UpdateTeam(TeamEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Teams
                    .Single(e => e.TeamId == model.TeamId);

                entity.TeamName = model.TeamName;
                
                return ctx.SaveChanges() == 1;
            }
        }
    }



}
