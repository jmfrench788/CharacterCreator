using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


    public class TeamEntity
    {
        [Key]
        public int Id {get;set;}
        public string TeamName {get;set;}

        [ForeignKey(nameof(Story))]
        public int StoryId {get;set;}
        public virtual StoryEntity Story {get;set;}

        // [ForeignKey(nameof(Character))]
        public List<CharacterEntity> Characters {get;set;}
    }
