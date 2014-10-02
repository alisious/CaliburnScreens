using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro.Validation;
using System.ComponentModel;



namespace CaliburnScreens.ViewModels
{
    public class GreenViewModel :ValidatingScreen<GreenViewModel>
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

        [Required(ErrorMessage = "Pole jest wymagane!")]
        [MinLength(3,ErrorMessage="Tekst powinien być dłuższy niż 3 znaki.")]
        public string SearchField
        {
            get { return _searchField;}
            
            set
            {
                
                _searchField = value;
                NotifyOfPropertyChange(() => SearchField);
                NotifyOfPropertyChange(() => CanForceCopyField);
                
               
            }
        }


        public void CopyField()
        {
            if (CanForceCopyField && CanSearchAutomatically)
                ForceCopyField();
               
        }

        public void ForceCopyField()
        {
            
            DestinationField = SearchField;
        }

        
        public bool CanForceCopyField
        {
            get { return SearchField.Length >= 3; }
        }

        private bool _canSearchAutomatically = true;
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
