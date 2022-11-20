using SpaceXhistory.ViewModels;
using SpaceXhistory.Models;

namespace SpaceXhistory.Views;

public partial class PastLaunchesPage : ContentPage
{
	private readonly PastLaunchesViewModel _viewModel;

	public PastLaunchesPage()
	{
		InitializeComponent();

		_viewModel = new PastLaunchesViewModel();
		BindingContext = _viewModel;

        _viewModel.PopulateLatestLaunchs();
    }

    private async void ListView_ItemTapped(Object sender, ItemTappedEventArgs e)
    {
        Root launch = e.Item as Root;

        try
        {
            Uri uri = new Uri(launch.links.webcast);
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            Console.Write(ex.Data);

            await DisplayAlert("An unexpected error occured",
                "No browser may be installed on the device",
                "Ok");
        }
    }
}
