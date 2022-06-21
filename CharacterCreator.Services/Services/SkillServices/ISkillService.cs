using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface ISkillService
    {
        Task<bool> CreateSkillAsync(SkillCreationDTO request);
        Task<bool> EditSkillAsync(SkillEditDTO request);
    }
