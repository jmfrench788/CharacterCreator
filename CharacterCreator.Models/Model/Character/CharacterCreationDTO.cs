using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class CharacterCreationDTO
    {
        public string Name { get; set; }
        public Race Race { get; set; }
        public Class Class { get; set; }
        public int TeamId { get; set; }
        // public int StoryId { get; set; }
    }
