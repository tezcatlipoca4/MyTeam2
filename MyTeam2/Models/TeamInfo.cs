namespace MyTeam2.Models
{
    namespace MyTeam2.Models
    {
        public class TeamInfo
        {
            public required string TeamName { get; set; }
            public required string TeamLabel { get; set; }
            public List<TeamSiteInfo> Sites { get; set; } = new();
        }
        
        public class TeamSiteInfo
        {
            public required string SiteName { get; set; }
            public required string Url { get; set; }
        }        
    }
}
