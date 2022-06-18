using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class CharacterService : ICharacterService
    {
        private readonly int _characterId;
        private readonly ApplicationDbContext _context;
        public CharacterService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCharacterAsync(CharacterCreationDTO request)
        {
            var characterEntity = new CharacterEntity
            {
                Id = _characterId,
                Name = request.Name,
                Race = request.Race,
                Class = request.Class,
                TeamId = request.TeamId,
                // StoryId = request.StoryId
            };
            await _context.Character.AddAsync(characterEntity);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
            
        }
    }
