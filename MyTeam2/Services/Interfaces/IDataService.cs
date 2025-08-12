using MyTeam2.Models;

namespace MyTeam2.Services.Interfaces
{
    public interface IDataService
    {
        List<Team> GetAllTeamsInfo();

        Team GetTeamByName(string name);

        Team GetTeamByLabel(string label);
    }
}