using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
public class CharacterEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Race Race { get; set; }
        public List<SkillEntity> Skills { get; set; }
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual TeamEntity  Team { get; set; }
        [ForeignKey(nameof(Story))]
        public int StoryId { get; set; }
        public virtual StoryEntity  Story { get; set; }
        // public int StrengthStat { get; set; }
        [Required]
        public Class Class { get; set; }
    }