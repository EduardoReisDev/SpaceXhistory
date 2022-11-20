using SpaceXhistory.ViewModels;
using SpaceXhistory.Models;

namespace SpaceXhistory.Views;

public partial class UpcomingLaunchesPage : ContentPage
{
	private readonly UpcomingLaunchesViewModel _viewModel;

	public UpcomingLaunchesPage()
	{
		InitializeComponent();

		_viewModel = new UpcomingLaunchesViewModel();
		BindingContext = _viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		_viewModel.PopulateNextLaunchs();
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
