using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _items;   // коллекция объектов (пользователей)
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _items; //для перечисления , бесчисленное поле

        public YouTubeViewersListingViewModel()
        {
            _items =
            [
                // и добавили объекты
                new YouTubeViewersListingItemViewModel("Mary"),
                new YouTubeViewersListingItemViewModel("Sean"),
                new YouTubeViewersListingItemViewModel("Alan"),
            ]; //объявили новую коллекцию объектов
        }
    }
}
