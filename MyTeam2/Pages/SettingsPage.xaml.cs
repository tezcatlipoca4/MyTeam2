using MyTeam2.Enums;
using MyTeam2.Models;
using MyTeam2.Services.Interfaces;
using System.Collections.ObjectModel;

namespace MyTeam2.Pages;

public partial class SettingsPage : ContentPage
{
    // Constructor for SettingsPage
    private IAppSettings _appSettings;
    private readonly IDataService _dataService;

    private readonly SettingsVM _settingsViewModel;

    private List<Team> _teamsInfo;

    public SettingsPage(
        IAppSettings appSettings,
        IDataService dataService)
    {
        InitializeComponent();

        _appSettings = appSettings;
        _dataService = dataService;

        _settingsViewModel = new SettingsVM(appSettings, dataService);

        _teamsInfo = _dataService.GetAllTeamsInfo();

        // Set the BindingContext to the ViewModel
        BindingContext = _settingsViewModel;

        SetPickerValues();
    }

    private void SetPickerValues()
    {
    }

    #region Event Handlers

    public void TeamPicker_OnSelectedIndexChanged(object sender, EventArgs e)
    {
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

        if (TeamPicker.SelectedIndex < 0 || TeamPicker.SelectedIndex >= _teamsInfo.Count)
        {
            DisplayAlert("Σφάλμα", "Δεν μπορείτε να αποθηκεύσετε τις ρθυμίσεις, χωρίς επιλεγμένη ομάδα!", "OK");
            return;
        }

        _settingsViewModel.SaveSettingsCommand.Execute(null);

        await Shell.Current.GoToAsync(".."); // Navigate back to the previous page
    }
}

#endregion
