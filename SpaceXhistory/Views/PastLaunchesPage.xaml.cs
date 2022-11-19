using SpaceXhistory.ViewModels;

namespace SpaceXhistory.Views;

public partial class PastLaunchesPage : ContentPage
{
	private readonly PastLaunchesViewModel _viewModel;

	public PastLaunchesPage()
	{
		InitializeComponent();

		_viewModel = new PastLaunchesViewModel();
		BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

		_viewModel.PopulateLatestLaunchs();
    }
}
