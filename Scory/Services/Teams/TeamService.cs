using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scory.Models;

namespace Scory.Services.Teams
{
    public class TeamService : ITeamService
    {
        private static readonly Dictionary<Guid, Team> _teams = new();
        public void CreateTeam(Team team)
        {
            _teams.Add(team.Id, team);
        }

        public void DeleteTeam(Guid id)
        {
            _teams.Remove(id);
        }

        public Team GetTeam(Guid id)
        {
            return _teams[id];
        }

        public void UpsertTeam(Team team)
        {
            _teams[team.Id] = team;
        }
    }
}