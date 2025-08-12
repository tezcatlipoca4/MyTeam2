using MyTeam2.Enums;
using MyTeam2.Models;
using MyTeam2.Services;
using MyTeam2.Services.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class SettingsVM : INotifyPropertyChanged
{
    private readonly IAppSettings _appSettings;
    private readonly IDataService _dataService;
    private readonly INavigationService _navigationService;

    private string _selectedTeamLabel;
    private LinkOpenOption _selectedLinkOpenOption;
    private ThemeOption _selectedThemeOption;
    private bool _isModernUi;
    private int _selectedArticlesPerPageOption;

    public event PropertyChangedEventHandler PropertyChanged;

    public SettingsVM(IAppSettings appSettings, IDataService dataService, INavigationService navigationService)
    {
        _appSettings = appSettings ?? throw new ArgumentNullException(nameof(appSettings));
        _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));
        _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));

        AvailableTeams = new ObservableCollection<string>(
            _dataService.GetAllTeamsInfo().Select(t => t.Label)
        );

        // Initialize defaults from stored settings
        if (!string.IsNullOrEmpty(_appSettings.SelectedTeamName))
        {
            SelectedTeam = _dataService.GetTeamByName(_appSettings.SelectedTeamName);
            SelectedTeamLabel = SelectedTeam?.Label ?? string.Empty;
        }

        SelectedLinkOpenOption = GetLinkOpenOptionFromSettings();
        SelectedThemeOption = GetThemeOptionFromSettings();
        SelectedArticlesPerPageOption = _appSettings.ArticlesPerPage;

        SaveSettingsCommand = new Command(async () => await SaveSettingsAsync(), CanSaveSettings);
    }

    public ObservableCollection<string> AvailableTeams { get; }
    public ObservableCollection<LinkOpenOption> LinkOpenOptions { get; } = new(Enum.GetValues<LinkOpenOption>());
    public ObservableCollection<ThemeOption> ThemeOptions { get; } = new(Enum.GetValues<ThemeOption>());

    public Team SelectedTeam { get; private set; }

    public string SelectedTeamLabel
    {
        get => _selectedTeamLabel;
        set
        {
            if (_selectedTeamLabel != value)
            {
                _selectedTeamLabel = value;
                SelectedTeam = _dataService.GetTeamByLabel(value);
                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedTeam));
                RaiseCanExecuteChanged();
            }
        }
    }

    public LinkOpenOption SelectedLinkOpenOption
    {
        get => _selectedLinkOpenOption;
        set
        {
            if (_selectedLinkOpenOption != value)
            {
                _selectedLinkOpenOption = value;
                OnPropertyChanged();
            }
        }
    }

    public ThemeOption SelectedThemeOption
    {
        get => _selectedThemeOption;
        set
        {
            if (_selectedThemeOption != value)
            {
                _selectedThemeOption = value;
                OnPropertyChanged();
                IsModernUi = value == ThemeOption.Modern;
            }
        }
    }

    public bool IsModernUi
    {
        get => _isModernUi;
        set
        {
            if (_isModernUi != value)
            {
                _isModernUi = value;
                OnPropertyChanged();
            }
        }
    }

    public int SelectedArticlesPerPageOption
    {
        get => _selectedArticlesPerPageOption;
        set
        {
            if (_selectedArticlesPerPageOption != value)
            {
                _selectedArticlesPerPageOption = value;
                OnPropertyChanged();
            }
        }
    }

    public int[] ArticlesPerPageOptions => DataService.ArticlePerPageOptions;

    public List<string> SelectedSites { get; set; } = new(); // Still here, but consider making it ObservableCollection if bound.

    public ICommand SaveSettingsCommand { get; }

    private LinkOpenOption GetLinkOpenOptionFromSettings() =>
        _appSettings.ExternalBrowserEnabled
            ? LinkOpenOption.DeviceBrowser
            : LinkOpenOption.InAppBrowser;

    private ThemeOption GetThemeOptionFromSettings() =>
        _appSettings.IsModernUi
            ? ThemeOption.Modern
            : ThemeOption.Minimal;

    private async Task SaveSettingsAsync()
    {
        _appSettings.SelectedTeamName = SelectedTeam?.Name ?? string.Empty;
        _appSettings.ExternalBrowserEnabled = SelectedLinkOpenOption == LinkOpenOption.DeviceBrowser;
        _appSettings.IsModernUi = SelectedThemeOption == ThemeOption.Modern;
        _appSettings.ArticlesPerPage = SelectedArticlesPerPageOption;

        // Notify UI to re-check CanExecute
        ((Command)SaveSettingsCommand).ChangeCanExecute();

        await _navigationService.GoBackAsync();
    }

    private bool CanSaveSettings()
    {
        return SelectedTeam != null && !string.IsNullOrEmpty(SelectedTeam.Name);
    }

    private void RaiseCanExecuteChanged()
    {
        if (SaveSettingsCommand is Command cmd)
            cmd.ChangeCanExecute();
    }

    protected void OnPropertyChanged([CallerMemberName] string name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
