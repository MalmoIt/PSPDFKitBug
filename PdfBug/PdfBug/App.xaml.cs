using Xamarin.Forms;

namespace PdfBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PdfPage());
            //new PdfPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    public class PdfModel
    {
        public string Uid { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
    }
}
