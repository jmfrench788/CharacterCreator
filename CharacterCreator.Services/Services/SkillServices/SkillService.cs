using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class SkillService : ISkillService
    {
        private readonly int _skillId;
        private readonly ApplicationDbContext _context;
        public SkillService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateSkillAsync(SkillCreationDTO request)
        {
            var skillEntity = new SkillEntity
            {
                Id = _skillId,
                CharacterId = request.CharacterId,
                Name = request.Name,
                Description = request.Description,
            };
        await _context.Skill.AddAsync(skillEntity);
        var numberOfChanges = await _context.SaveChangesAsync();
        return numberOfChanges == 1;
        }

        public async Task<bool> EditSkillAsync(SkillEditDTO request)
        {
            var skillEntity = new SkillEntity
            {
                Name = request.Name,
                Description = request.Description
            };
            await _context.Skill.AddAsync(skillEntity);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }
    }
