using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;
        private readonly ILogger<SkillController> _logger;

        public SkillController(ILogger<SkillController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Add Skills")]
        public async Task<IActionResult> CreateSkill([FromBody] SkillCreationDTO request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var skillCreationResult = await _skillService.CreateSkillAsync(request);
            if (skillCreationResult)
            {
                return Ok("Skill has been added");
            }

            return BadRequest("Failed to add skill");
        }

        
    }
