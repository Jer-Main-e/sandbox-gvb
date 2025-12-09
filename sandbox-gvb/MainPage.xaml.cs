namespace sandbox_gvb
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnStationTapped(object sender, EventArgs e)
        {
            DisplayAlert("Station", "Je hebt station X aangeklikt!", "OK");
        }
    }
}
