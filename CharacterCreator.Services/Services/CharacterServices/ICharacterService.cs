using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface ICharacterService
    {
        Task<bool> CreateCharacterAsync(CharacterCreationDTO request);
        Task<CharacterDetailDTO> GetCharacterByIdASync (int characterId);
    }
