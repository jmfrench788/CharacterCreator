using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


    public class StoryEntity
    {
         [Key]
        public int Id {get;set;}
        public string StoryName {get;set;}

        public string StoryDescription {get;set;}

        //FK Teams
        // [ForeignKey(nameof(Team))]
        public virtual List<TeamEntity> Teams {get;set;}
        
    }
