namespace story2._0
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new NewPage1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("ALERT", "MADE BY JASXXN", "exit");
        }
    }
}