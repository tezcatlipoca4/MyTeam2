using MyTeam2.Models;
using MyTeam2.Models.ViewModels;
using MyTeam2.Services.Interfaces;
using System.Collections.ObjectModel;

namespace MyTeam2.Pages.Settings;

public partial class SettingsPage : ContentPage
{
    // Constructor for SettingsPage
    private readonly ITeamService _teamService;

    private List<Team> _teamsInfo;

    private readonly AvailableSitesVM _viewModel = new();

    public SettingsPage(ITeamService teamService)
    {
        InitializeComponent();

        _teamService = teamService;

        _teamsInfo = _teamService.GetAllTeamsInfo();

        // Populate the team picker with team names
        foreach (var team in _teamsInfo)
        {
            TeamPicker.Items.Add(team.Label);
        }
    }

    #region Event Handlers

    public void TeamPicker_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        // Get the selected team index
        int selectedIndex = TeamPicker.SelectedIndex;
        if (selectedIndex < 0 || selectedIndex >= _teamsInfo.Count)
            return;

        // Get the selected team
        var selectedTeam = _teamsInfo[selectedIndex];

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

    public void SaveSettingsButton_OnClicked(object sender, EventArgs e)
    {
        // Handle settings click event
        DisplayAlert("Settings", "Settings clicked!", "OK");
    }

    #endregion
}