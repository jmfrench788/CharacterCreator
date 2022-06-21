using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
       private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam([FromBody] TeamCreateDTO request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(await _teamService.CreateTeamAsync(request))
            {
                return Ok("Team was created.");
            }

            return BadRequest("Team could not be created.");
        }

        [HttpGet]
        [Route("{teamId}")]
        public async Task<IActionResult> GetTeamById([FromRoute] int teamId)
        {
            var teamDetail = await _teamService.GetTeamByIdASync(teamId);

            if(teamDetail is null)
                {
                    return NotFound();
                }
            
            return Ok(teamDetail);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeamById([FromBody] TeamUpdateDTO request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

                return await _teamService.UpdateTeamAsync(request) 
                    ? Ok("Team was updated.") : BadRequest("Team could not be updated.");
        }

        [HttpDelete]
        [Route("{teamId}")]
        public async Task<IActionResult> DeleteTeam([FromRoute] int teamId)
        {
            return await  _teamService.DeleteTeamAsync(teamId) 
                ? Ok($"Team {teamId} was deleted.") : BadRequest($"Team {teamId} could not be deleted");
        }

        //Get
    }
