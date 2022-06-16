using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CharacterEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Race Race { get; set; }
        public List<SkillEntity> Skills { get; set; }
        public TeamEntity  Team { get; set; }
        public int StrengthStat { get; set; }
        public Class Class { get; set; }
    }