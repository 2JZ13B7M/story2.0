namespace story2._0;

public class Main_menu : ContentPage
{
	public Main_menu()
	{
		Content = new StackLayout
		{
			Children = {
				new Label { Text = "Welcome to .NET MAUI!" }
			}
		};
	}
}