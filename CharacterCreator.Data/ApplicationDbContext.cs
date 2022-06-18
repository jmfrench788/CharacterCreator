using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {    
            }
        public DbSet<CharacterEntity> Character { get; set; }
        public DbSet<SkillEntity> Skill { get; set; }
        public DbSet<StoryEntity> Story { get; set; }
        public DbSet<TeamEntity> Team { get; set; }

    }
