namespace Lands
{
    using Views;
    using Xamarin.Forms;

    public partial class App : Application
    {
        #region Constructors

        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
        }
        #endregion

        #region Functions
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion
    }
}
