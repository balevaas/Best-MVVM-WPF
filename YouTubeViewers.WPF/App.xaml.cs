using System.Windows;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Зачем то подключаем окно так же как в WinForm, убрала путь из App.xaml
            MainWindow = new MainWindow()
            {
                // связали DataContext c основной VM
                DataContext = new YouTubeViewersViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
