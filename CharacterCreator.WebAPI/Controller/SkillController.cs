using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class SkillController : ControllerBase
    {
        private readonly ILogger<SkillController> _logger;

        public SkillController(ILogger<SkillController> logger)
        {
            _logger = logger;
        }

        
    }
