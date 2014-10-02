using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnScreens.ViewModels
{
    public class AppViewModel :Conductor<IScreen>.Collection.OneActive, IHaveDisplayName
    {

        public AppViewModel()
        {
            DisplayName = "AppViewModel";
        }
       
        public void ShowRedScreen()
        {
            DisplayName = "RedViewModel";
            ActivateItem(new RedViewModel());
        }

        public void ShowGreenScreen()
        {
            DisplayName = "GreenViewModel";
            ActivateItem(new GreenViewModel());
        }
    }
}
