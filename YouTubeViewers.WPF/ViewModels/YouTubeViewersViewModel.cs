using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        // связка с VM для отдельных User Contols
        public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get; }
        public YouTubeViewersDetailsViewModel YouTuveViewersDetailsViewModel { get; }

        // связка для кнопки 
        public ICommand AddYouTubeViewersCommand { get; }

        public YouTubeViewersViewModel()
        {
            // в конструкторе создали экземпляры VM 
            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel();
            YouTuveViewersDetailsViewModel = new YouTubeViewersDetailsViewModel();
        }
    }
}
