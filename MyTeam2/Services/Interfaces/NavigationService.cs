using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam2.Services.Interfaces
{
    public class NavigationService : INavigationService
    {
        public Task GoBackAsync()
        {
            return Shell.Current.GoToAsync("..");
        }

        public Task NavigateToAsync(string route)
        {
            return Shell.Current.GoToAsync(route);
        }
    }
}
