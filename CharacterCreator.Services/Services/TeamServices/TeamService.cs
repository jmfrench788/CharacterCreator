using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class TeamService
    {

        private readonly ApplicationDbContext _context;

        private readonly ITeamService _teamService;

        public TeamService(ApplicationDbContext context)
        {
            _context = context;
        }
        //Create

        public async Task<bool> CreateTeamAsync (TeamCreateDTO teamCreateDTO)
        {
            TeamEntity team = new TeamEntity
            {
                Id = teamCreateDTO.Id,
                TeamName = teamCreateDTO.TeamName
            };

            _context.Team.Add(team);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges ==1;
        }


        //Get by TeamID

        //Update
        public async Task<bool> UpdateTeamAsync(TeamUpdateDTO request)
        {
            var teamEntity = await _context.Team.FindAsync(request.Id);
            if(teamEntity == null)
            {
                return false;
            }
            else
            {
                teamEntity.TeamName = request.TeamName;
                teamEntity.StoryId = request.StoryId;
            }

            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges ==1;
        }

        //Delete
           public async Task<bool> DeleteTeamAsync(int teamId)
       {
           var teamEntity = await _context.Team.FindAsync(teamId);
           if(teamEntity == null)
           {
               return false;
           }

           _context.Team.Remove(teamEntity);
           return await _context.SaveChangesAsync()==1;
       }
    }
