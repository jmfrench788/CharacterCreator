using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class StoryServices : IStoryServices
    {

        private readonly ApplicationDbContext _context;

        private readonly IStoryServices _storyService;

        public StoryServices(ApplicationDbContext context)
        {
            _context = context;
        }
        //Create
       public async Task<bool> CreateStoryAsync (StoryCreateDTO storyCreateDTO)
       {
            StoryEntity story = new StoryEntity
            {
                Id = storyCreateDTO.Id,
                StoryName = storyCreateDTO.StoryName,
                StoryDescription = storyCreateDTO.StoryDescription
            };

            _context.Story.Add(story);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges ==1;
       }

        //Get by Story ID

        //Update

        //Delete
    }
