using SpaceXhistory.ViewModels;
using SpaceXhistory.Models;

namespace SpaceXhistory.Views;

public partial class HomePage : ContentPage
{
	private readonly HomePageViewModel _viewModel;

	public HomePage()
	{
		InitializeComponent();

		_viewModel = new HomePageViewModel();
		BindingContext = _viewModel;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		_viewModel.GetNextLaunch();
		_viewModel.GetLatestLaunch();
		_viewModel.GetRoadsterInfo();
	}

	private void NextLaunchWebcastTap(object sender, TappedEventArgs e)
	{
        OpenUrl(_viewModel.NextLaunch.links.webcast);
    }

    private void LatestLaunchWebcastTap(object sender, TappedEventArgs e)
    {
        OpenUrl(_viewModel.LatestLaunch.links.webcast);
    }

    private void RoadsterWebcastTap(object sender, TappedEventArgs e)
    {
        OpenUrl(_viewModel.RoadsterInfo.video);
    }

    private void RoadsterWikiTap(object sender, TappedEventArgs e)
    {
        OpenUrl(_viewModel.RoadsterInfo.wikipedia);
    }

	private async void OpenUrl(string link)
	{
        try
        {
            Uri uri = new Uri(link);
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
