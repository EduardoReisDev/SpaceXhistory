using SpaceXhistory.ViewModels;

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
}
