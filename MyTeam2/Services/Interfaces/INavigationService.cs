using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeam2.Services.Interfaces
{
    public interface INavigationService
    {
        Task GoBackAsync();
        Task NavigateToAsync(string route);
    }
}
