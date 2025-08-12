using MyTeam2.Services.Interfaces;

namespace MyTeam2.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(IAppSettings appSettings, IDataService dataService, INavigationService navigationService)
    {
        InitializeComponent();

        // Instantiate ViewModel and assign BindingContext
        BindingContext = new SettingsVM(appSettings, dataService, navigationService);
    }
}