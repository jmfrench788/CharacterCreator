using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class CharacterDetailDTO
    {
        public string Name { get; set; }
        public Race Race { get; set; }
        public Class Class { get; set; }
        public List<SkillEntity> Skill { get; set; }
    }
