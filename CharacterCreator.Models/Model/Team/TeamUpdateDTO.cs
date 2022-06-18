using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class TeamUpdateDTO
    {
        public int Id {get;set;}
        public string TeamName {get;set;}
        public int StoryId {get;set;}
        public List<CharacterEntity> Characters {get;set;}
    }
