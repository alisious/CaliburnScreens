using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnScreens.ViewModels
{
    public class MainViewModel :PropertyChangedBase
    {
        private const string WindowTitleDefault = "Okno główne aplikacji.";
        private string _windowTitle = WindowTitleDefault;

        public string WindowTitle 
        {
            get { return _windowTitle; }
            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }
    }
}
