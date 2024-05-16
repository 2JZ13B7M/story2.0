namespace story2._0;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
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

    

    private void D_Clicked(object sender, EventArgs e)
    {
        if (C.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
        {
            C.Pause();
            D.Text = "Listen";
        }
        else if (C.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
        {
            C.Play();
            D.Text = "Listen";
        }
    }
}
