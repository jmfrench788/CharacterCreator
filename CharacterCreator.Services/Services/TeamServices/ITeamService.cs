using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface ITeamService
    {
        //Create
        Task<bool> CreateTeamAsync (TeamCreateDTO teamCreateDTO);

        //Get by TeamID

        //Update
        Task<bool> UpdateTeamAsync(TeamUpdateDTO request);

        //Delete
    }
