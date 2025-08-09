namespace MyTeam2.Models
{
    public class Team
    {
        public required string Name { get; set; }

        public required string Label { get; set; }

        public List<TeamSiteInfo> Sites { get; set; } = new();
    }

    public class TeamSiteInfo
    {
        public required Site Site { get; set; }

        public string TeamUrl { get; set; }
    }
}
