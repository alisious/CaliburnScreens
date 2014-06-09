using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnScreens.ViewModels
{
    public class GreenViewModel :Screen
    {
        private string _destinationField = "";
        public string DestinationField 
        {
            get { return _destinationField;}
            set
            {
                _destinationField = value;
                NotifyOfPropertyChange(() => DestinationField);
            }
        }

        private string _searchField = "";
        public string SearchField
        {
            get { return _searchField;}
            set
            {
                
                _searchField = value;
                NotifyOfPropertyChange(() => SearchField);
                
               
            }
        }


        public void CopyField()
        {
            if (SearchField.Length >= 3 && CanSearchAutomatically)
                ForceCopyField();
               
        }

        public void ForceCopyField()
        {
            DestinationField = SearchField;
        }


        private bool _canSearchAutomatically = false;
        public bool CanSearchAutomatically
        {
            get { return _canSearchAutomatically; }
            set 
            {
                _canSearchAutomatically = value;
                NotifyOfPropertyChange(() => CanSearchAutomatically);
            }


        }

        
    }
}
