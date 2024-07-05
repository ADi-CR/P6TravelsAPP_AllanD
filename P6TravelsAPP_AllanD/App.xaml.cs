using P6TravelsAPP_AllanD.Views;

namespace P6TravelsAPP_AllanD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
