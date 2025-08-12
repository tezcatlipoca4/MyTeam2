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
    private IAppSettings _appSettings;
    private readonly IDataService _dataService;

    public ICommand SaveSettingsCommand { get; private set; }

    public Team SelectedTeam { get; set; }

    public List<string> SelectedSites { get; set; } = new();

    public List<string> AvailableTeams;

    public int[] ArticlesPerPageOptions => DataService.ArticlePerPageOptions;

    public event PropertyChangedEventHandler PropertyChanged;

    public SettingsVM(IAppSettings appSettings, IDataService dataService)
    {
        _appSettings = appSettings ?? throw new ArgumentNullException(nameof(appSettings));
        _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));

        AvailableTeams = _dataService.GetAllTeamsInfo().Select(t => t.Label).ToList();

        // Initialize default values from app settings        
        if (!string.IsNullOrEmpty(_appSettings.SelectedTeamName))
        {
            SelectedTeam = _dataService.GetTeamByName(_appSettings.SelectedTeamName); 
            SelectedTeamLabel = SelectedTeam.Label;
        }

        SelectedLinkOpenOption = _appSettings.ExternalBrowserEnabled ? LinkOpenOption.DeviceBrowser : LinkOpenOption.InAppBrowser;
        SelectedThemeOption = _appSettings.IsModernUi ? ThemeOption.Modern : ThemeOption.Minimal;
        SelectedArticlesPerPageOption = _appSettings.ArticlesPerPage;

        SaveSettingsCommand = new Command(SaveSettings);
    }

    public ObservableCollection<LinkOpenOption> LinkOpenOptions { get; } = new(Enum.GetValues<LinkOpenOption>());
    public ObservableCollection<ThemeOption> ThemeOptions { get; } = new(Enum.GetValues<ThemeOption>());

    private string _selectedTeamLabel { get; set; }
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
            }
        }
    }

    private LinkOpenOption _selectedLinkOpenOption;
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

    private ThemeOption _selectedThemeOption;
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

    private bool _isModernUi;
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

    private int _selectedArticlesPerPageOption;
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

    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    private void SaveSettings()
    {
        _appSettings.SelectedTeamName = SelectedTeam.Name;
        _appSettings.ExternalBrowserEnabled = SelectedLinkOpenOption == LinkOpenOption.DeviceBrowser;
        _appSettings.IsModernUi = SelectedThemeOption == ThemeOption.Modern;
        _appSettings.ArticlesPerPage = SelectedArticlesPerPageOption;
    }
}
