using CharacterApp.Data;
using CharacterApp.Models.TeamModel;
using System;

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
    }



}
