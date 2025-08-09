namespace MyTeam2.Models
{
    public class Settings
    {
        public required string SelectedTeam { get; set; }

        public List<string> selectedSites { get; set; } = [];

        public bool ExternalBrowserEnabled { get; set; }

        public int ArticlesPerPage { get; set; }

        public bool ModernUi { get; set; }
    }
}
