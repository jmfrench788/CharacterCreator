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

    public async Task<CharacterDetailDTO> GetCharacterByIdASync(int characterId)
    {
        var characterEntity = await _context.Character.FindAsync(characterId);
        if (characterEntity is null)
            return null;

        var characterDetail = new CharacterDetailDTO
        {
            Id = characterEntity.Id,
            Name = characterEntity.Name,
            Race = characterEntity.Race,
            Class = characterEntity.Class,
            Skills = characterEntity.Skills
        };

        return characterDetail;
    }
}
