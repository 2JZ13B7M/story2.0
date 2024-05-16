namespace story2._0;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new audi());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new NewPage2());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new porsche911());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new MainPage());
    }
}
