using Plugin.Maui.Audio;

namespace story2._0;


public partial class audi : ContentPage
{
	public audi()
	{
		InitializeComponent();
        
    }
    public class AudioPlayerViewModel
    {
        readonly IAudioManager audioManager;

        public AudioPlayerViewModel(IAudioManager audioManager)
        {
            this.audioManager = audioManager;
        }

        public async void PlayAudio()
        {
            var audioPlayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("carrera.mp3"));

            audioPlayer.Play();
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (A.CurrentState==CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing ) 
        {
            A.Pause();
            B.Text = "play";
        }
        else if(A.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
        {
            A.Play();
            B.Text = "pause";
        }
    }

    private void c_Clicked(object sender, EventArgs e)
    {
        if (C.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
        {
            C.Pause();
            D.Text = "play";
        }
        else if (C.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
        {
            C.Play();
            D.Text = "pause";
        }
    }
}