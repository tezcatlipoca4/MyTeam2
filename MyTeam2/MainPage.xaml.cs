using MyTeam2.Pages;
using MyTeam2.Services.Interfaces;

namespace MyTeam2
{
    public partial class MainPage : ContentPage
    {
        private IAppSettings _appSettings;
        private readonly ITeamService _teamService;

        public MainPage(
            IAppSettings appSettings,
            ITeamService teamService)
        {
            InitializeComponent();
            
            _appSettings = appSettings;
            _teamService = teamService;
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}
