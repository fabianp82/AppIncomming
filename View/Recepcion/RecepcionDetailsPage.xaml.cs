
using Com.Datalogic.Decode;

namespace AppPicking.View;

public partial class RecepcionDetailsPage : ContentPage
{
	public RecepcionDetailsPage(RecepcionDetailsPageViewModel viewModel)
	{
        InitializeComponent();
        this.BindingContext = viewModel;

#if ANDROID
        MessagingCenter.Subscribe<MainActivity, IDecodeResult>(this, "decodeResult", async (sender, arg) =>
        {

            HelloLbl.Text = arg.Text;
            WelcomeLbl.Text = arg.BarcodeID.ToString();

            SemanticScreenReader.Announce(HelloLbl.Text);
            SemanticScreenReader.Announce(WelcomeLbl.Text);
        });

#endif

    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}