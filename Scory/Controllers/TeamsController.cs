using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scory.Contracts.Team;
using Scory.Models;
using Scory.Services.Teams;

namespace Scory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetTeam(Guid id)
        {
            Team team = _teamService.GetTeam(id);
            
            var response = new TeamResponse(
                team.Id,
                team.Name,
                team.City,
                team.Country,
                team.Arena,
                team.Description,
                team.LogoUrl,
                team.WebsiteUrl,
                team.Players);

            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateTeam(CreateTeamRequest request)
        {
            var team = new Team(
                Guid.NewGuid(),
                request.Name,
                request.City,
                request.Country,
                request.Arena,
                request.Description,
                request.LogoUrl,
                request.WebsiteUrl,
                request.Players);

            _teamService.CreateTeam(team);

            var response = new TeamResponse(
                team.Id,
                team.Name,
                team.City,
                team.Country,
                team.Arena,
                team.Description,
                team.LogoUrl,
                team.WebsiteUrl,
                team.Players);
            
            return CreatedAtAction(
                nameof(GetTeam),
                new { id = response.Id },
                response
            );
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertTeam(Guid id,UpsertTeamRequest request)
        {
            var team = new Team(
                id,
                request.Name,
                request.City,
                request.Country,
                request.Arena,
                request.Description,
                request.LogoUrl,
                request.WebsiteUrl,
                request.Players);

            _teamService.UpsertTeam(team);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteTeam(Guid id)
        {
            _teamService.DeleteTeam(id);

            return NoContent();
        }
    }
}