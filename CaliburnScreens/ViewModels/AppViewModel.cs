using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnScreens.ViewModels
{
    public class AppViewModel :Conductor<IScreen>.Collection.OneActive
    {

        public AppViewModel()
        {
            DisplayName = "AppViewModel";
            Items.Add(new RedViewModel());
            Items.Add(new GreenViewModel());
            ActivateItem(Items[1]);
        }
       
        public void ShowRedScreen()
        {
            DisplayName = "RedViewModel";
            ActivateItem(DetermineNextItemToActivate(Items,Items.IndexOf(ActiveItem)));
        }

        public void ShowGreenScreen()
        {
            DisplayName = "GreenViewModel";
            ActivateItem(new GreenViewModel());
        }
    }
}
