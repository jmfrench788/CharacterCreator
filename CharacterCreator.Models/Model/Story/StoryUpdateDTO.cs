using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class StoryUpdateDTO
    {
          public int Id {get;set;}
        public string StoryName {get;set;}

        public string StoryDescription {get;set;}

        public List<TeamEntity> Teams {get;set;}
    }
