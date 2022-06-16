using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


public class SkillEntity
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public string Name {get; set;}

        [Required]
        public string Description {get; set;}

        [ForeignKey(nameof(Character))]

        public int CharacterId {get;set;}
        public virtual CharacterEntity Character {get;set;}
    }
