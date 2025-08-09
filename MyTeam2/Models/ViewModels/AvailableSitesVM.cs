using System.Collections.ObjectModel;
using System.ComponentModel;
using MyTeam2.Models;

namespace MyTeam2.Models.ViewModels
{
    public class AvailableSitesVM : INotifyPropertyChanged
    {
        public ObservableCollection<Site> AvailableSites { get; set; } = new();

        public event PropertyChangedEventHandler? PropertyChanged;

        // Call this method to notify the UI of property changes
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}