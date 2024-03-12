using System.Windows.Input;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersListingItemViewModel : ViewModelBase
    {
        public string UserName { get; } //свойство для имени пользователя
        public ICommand EditCommand { get; } // команда для изменения на кнопки
        public ICommand DeleteCommand { get; } // команда для удаления

        //конструктор
        public YouTubeViewersListingItemViewModel(string username)
        {
            UserName = username;
        }
    }
}
