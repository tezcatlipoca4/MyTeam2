using MyTeam2.Services.Interfaces;

namespace MyTeam2
{
    public partial class MainPage : ContentPage
    {
        private readonly ITeamService _teamService;

        public MainPage(ITeamService teamService)
        {
            InitializeComponent();
            _teamService = teamService;
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.Settings.SettingsPage(_teamService));
        }
    }
}
