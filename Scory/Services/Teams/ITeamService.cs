using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scory.Contracts.Team;
using Scory.Models;

namespace Scory.Services.Teams
{
    public interface ITeamService
    {
        void CreateTeam(Team team);
        void DeleteTeam(Guid id);
        Team GetTeam(Guid id);
        void UpsertTeam(Team team);
    }
}