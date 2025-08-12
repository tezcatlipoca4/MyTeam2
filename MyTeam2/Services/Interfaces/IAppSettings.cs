using System.ComponentModel;

namespace MyTeam2.Services.Interfaces
{
    public interface IAppSettings : INotifyPropertyChanged
    {
        string SelectedTeamName { get; set; }
        List<string> SelectedSites { get; set; }
        bool ExternalBrowserEnabled { get; set; }
        int ArticlesPerPage { get; set; }
        bool IsModernUi { get; set; }

        // helpers for safely mutating collections
        void AddSite(string site);
        void RemoveSite(string site);
    }
}
