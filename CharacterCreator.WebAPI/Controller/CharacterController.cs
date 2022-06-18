using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly ILogger<CharacterController> _logger;
        
        public CharacterController(ILogger<CharacterController> logger, ICharacterService characterService)
        {
            _logger = logger;
            _characterService = characterService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> CreateCharacter([FromBody] CharacterCreationDTO request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var creationResult = await _characterService.CreateCharacterAsync(request);
            if (creationResult)
            {
                return Ok("User was registered.");
            }

            return BadRequest("User could not be registered.");
        }

        [HttpGet("{characterId:int}")]
        public async Task<IActionResult> GetById([FromRoute] int characterId)
        {
            var characterDetail = await _characterService.GetCharacterByIdASync(characterId);

            if(characterDetail is null)
                {
                    return NotFound();
                }
            
            return Ok(characterDetail);
        }
    }
