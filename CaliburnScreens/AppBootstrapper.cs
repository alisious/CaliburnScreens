﻿using Caliburn.Micro;
using CaliburnScreens.ViewModels;

namespace CaliburnScreens
{
    public class AppBootstrapper :BootstrapperBase 
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<AppViewModel>();
        }
    }
}
