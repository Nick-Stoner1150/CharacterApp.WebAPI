using CharacterApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace CharacterApp.Services
{
    public class TeamService
    {
        private readonly Guid _userId;

        public TeamService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTeam(TeamCreate team)
        {
            var entity =
                new Team()
                {
                    TeamName = team.TeamName,
                    TeamId = team.Id,

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }

        
        
    }
