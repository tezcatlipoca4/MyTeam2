using MyTeam2.Models;
using MyTeam2.Services.Interfaces;
using System.Collections.ObjectModel;
using static MyTeam2.Enums.SettingsEnums;

namespace MyTeam2.Pages;

public partial class SettingsPage : ContentPage
{
    // Constructor for SettingsPage
    private IAppSettings _appSettings;
    private readonly ITeamService _teamService;

    private List<Team> _teamsInfo;

    public SettingsPage(
        IAppSettings appSettings,
        ITeamService teamService
        )
    {
        InitializeComponent();

        _appSettings = appSettings;
        _teamService = teamService;

        _teamsInfo = _teamService.GetAllTeamsInfo();

        PopulatePickers();

        SetPickerValues();
    }

    private void PopulatePickers()
    {
        // Populate the team picker with team names
        foreach (var team in _teamsInfo)
        {
            TeamPicker.Items.Add(team.Label);
        }

        // Populate rest of the UI elements
        LinkPicker.Items.Add(LinkOpenOption.BrowserApp.ToString());
        LinkPicker.Items.Add(LinkOpenOption.BrowserDevice.ToString());

        ThemePicker.Items.Add(ThemeOption.Modern.ToString());
        ThemePicker.Items.Add(ThemeOption.Minimal.ToString());

        foreach (var number in Enum.GetValues<ArticlesPerPageOption>().Select(e => (int)e).ToList())
        {
            ArticlesPerPagePicker.Items.Add(number.ToString());
        }
    }

    private void SetPickerValues()
    {
        // Set the initial values for the pickers based on app settings
        LinkPicker.SelectedIndex = _appSettings.ExternalBrowserEnabled ? 0 : 1;
        ThemePicker.SelectedIndex = _appSettings.ModernUi ? 0 : 1;
        ArticlesPerPagePicker.SelectedIndex = _appSettings.ArticlesPerPage / 5 - 1; // Assuming ArticlesPerPage is always a multiple of 5

        // Set the initial selected team based on app settings
        if (_appSettings != null && !string.IsNullOrEmpty(_appSettings.SelectedTeam))
        {
            int index = _teamsInfo.FindIndex(t => t.Name == _appSettings.SelectedTeam);
            if (index >= 0)
            {
                TeamPicker.SelectedIndex = index;
            }
        }

    }

    #region Event Handlers

    public void TeamPicker_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        // Get the selected team index
        int selectedIndex = TeamPicker.SelectedIndex;

        if (selectedIndex < 0 || selectedIndex >= _teamsInfo.Count)
        {
            return;
        }

        // Get the selected team
        var selectedTeam = _teamsInfo[selectedIndex];

        // Populate available sites collection view with sites from the selected team
        AvailableSitesCollectionView.ItemsSource = new ObservableCollection<Site>(selectedTeam.Sites.Select(s => s.Site));
    }

    public void urlPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Handle URL picker selection change event
        DisplayAlert("URL Picker", "Selected index changed!", "OK");
    }

    public void articlePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Handle team picker selection change event
        DisplayAlert("Team Picker", "Selected index changed!", "OK");
    }

    public void thePicker_Changed(object sender, EventArgs e)
    {
        // Handle settings click event
        DisplayAlert("Settings", "Settings clicked!", "OK");
    }

    public async void SaveSettingsButton_OnClicked(object sender, EventArgs e)
    {
        // Save the selected team to app settings
        if (TeamPicker.SelectedIndex < 0 || TeamPicker.SelectedIndex >= _teamsInfo.Count)
        {
            DisplayAlert("Σφάλμα", "Δεν μπορείτε να αποθηκεύσετε τις ρθυμίσεις, χωρίς επιλεγμένη ομάδα!", "OK");
            return;
        }

        // TODO: Check that at least one site is selected before saving

        // Save settings and return to previous page
        _appSettings.SelectedTeam = _teamsInfo[TeamPicker.SelectedIndex].Name;
        // TODO: Save selected sites to app settings
        _appSettings.ExternalBrowserEnabled = LinkPicker.SelectedIndex == 0;
        _appSettings.ModernUi = ThemePicker.SelectedIndex == 0;
        _appSettings.ArticlesPerPage = (ArticlesPerPagePicker.SelectedIndex + 1) * 5; // Assuming ArticlesPerPage is always a multiple of 5

        await Shell.Current.GoToAsync(".."); // Navigate back to the previous page
    }
}

#endregion
