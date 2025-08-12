using MyTeam2.Pages;
using MyTeam2.Services.Interfaces;

namespace MyTeam2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(
            IAppSettings appSettings,
            IDataService teamService)
        {
            InitializeComponent();
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}
