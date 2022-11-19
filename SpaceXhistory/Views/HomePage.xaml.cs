using SpaceXhistory.ViewModels;

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
		_viewModel.GetLastedLaunch();
	}
}
