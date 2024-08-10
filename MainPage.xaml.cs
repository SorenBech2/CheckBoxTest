namespace SfRadioButton_test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }
    }

}
