namespace story2._0;

public partial class porsche : ContentPage
{
	public porsche()
	{
		InitializeComponent();
	}

    private void B_Clicked(object sender, EventArgs e)
    {
        if (A.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
        {
            A.Pause();
            B.Text = "play";
        }
        else if (A.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
        {
            A.Play();
            B.Text = "pause";
        }
    }
}