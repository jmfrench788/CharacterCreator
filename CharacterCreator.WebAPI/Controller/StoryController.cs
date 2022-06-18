using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class StoryController : ControllerBase
    {
         private readonly IStoryServices _storyService;

        public StoryController(IStoryServices storyService)
        {
            _storyService = storyService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStory([FromBody] StoryCreateDTO request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(await _storyService.CreateStoryAsync(request))
            {
                return Ok("Story was created.");
            }

            return BadRequest("Story could not be created.");
        }

    }
