using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Import_Click(object sender, RoutedEventArgs e)
        {
            var path = "https://images.pexels.com/photos/460621/pexels-photo-460621.jpeg?cs=srgb&dl=pexels-pixabay-460621.jpg&fm=jpg";
            var image = await ToImageAsync(path);
            MyImage.Source = image;

        }

        private async Task<ImageSource> ToImageAsync(string path)
        {
            var httpClint = new HttpClient();
            var imageBytes = await httpClint.GetStreamAsync(path);

            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.StreamSource = imageBytes;
            bitmapImage.EndInit();

            return bitmapImage;
        }
    }
}
