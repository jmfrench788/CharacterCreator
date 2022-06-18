using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface ITeamService
    {
        //Create
        Task<bool> CreateTeamAsync (TeamCreateDTO teamCreateDTO);

        //Get by TeamID
        Task<TeamDetailDTO> GetTeamByIdASync(int teamId);

        //Update
        Task<bool> UpdateTeamAsync(TeamUpdateDTO request);

        //Delete
        Task<bool> DeleteTeamAsync(int teamId);
    }
