using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnScreens.ViewModels
{
    public class RedViewModel :Screen
    {
        public void ShowGreenScreen()
        {
            var p = this.Parent as Conductor<IScreen>.Collection.OneActive;
            p.ActivateItem(p.Items[1]);
            
        }
    }
}
