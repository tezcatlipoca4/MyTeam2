using MyTeam2.Services.Interfaces;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace MyTeam2.Services
{
    public class AppSettings : IAppSettings
    {
        const string SelectedTeamKey = nameof(SelectedTeam);
        const string SelectedSitesKey = nameof(SelectedSites);
        const string ExternalBrowserEnabledKey = nameof(ExternalBrowserEnabled);
        const string ModernUiKey = nameof(ModernUi);
        const string ArticlesPerPageKey = nameof(ArticlesPerPage);

        public event PropertyChangedEventHandler? PropertyChanged;

        // string
        public string SelectedTeam
        {
            get => Preferences.Get(SelectedTeamKey, string.Empty);
            set
            {
                if (value is null) value = string.Empty;
                if (value == SelectedTeam) return;
                Preferences.Set(SelectedTeamKey, value);
                OnPropertyChanged();
            }
        }

        // list stored as JSON
        public List<string> SelectedSites
        {
            get
            {
                var json = Preferences.Get(SelectedSitesKey, "[]");
                try
                {
                    return JsonSerializer.Deserialize<List<string>>(json) ?? new List<string>();
                }
                catch
                {
                    // fallback if corrupted
                    return new List<string>();
                }
            }
            set
            {
                var json = JsonSerializer.Serialize(value ?? new List<string>());
                Preferences.Set(SelectedSitesKey, json);
                OnPropertyChanged();
            }
        }

        public void AddSite(string site)
        {
            if (string.IsNullOrWhiteSpace(site)) return;
            var list = SelectedSites;
            if (!list.Contains(site))
            {
                list.Add(site);
                SelectedSites = list; // persist and raise event
            }
        }

        public void RemoveSite(string site)
        {
            var list = SelectedSites;
            if (list.Remove(site))
                SelectedSites = list; // persist and raise event
        }

        public bool ExternalBrowserEnabled
        {
            get => Preferences.Get(ExternalBrowserEnabledKey, false);
            set
            {
                if (value == ExternalBrowserEnabled) return;
                Preferences.Set(ExternalBrowserEnabledKey, value);
                OnPropertyChanged();
            }
        }

        public bool ModernUi
        {
            get => Preferences.Get(ModernUiKey, false);
            set
            {
                if (value == ModernUi) return;
                Preferences.Set(ModernUiKey, value);
                OnPropertyChanged();
            }
        }

        public int ArticlesPerPage
        {
            get => Preferences.Get(ArticlesPerPageKey, 10);
            set
            {
                if (value == ArticlesPerPage) return;
                Preferences.Set(ArticlesPerPageKey, value);
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}