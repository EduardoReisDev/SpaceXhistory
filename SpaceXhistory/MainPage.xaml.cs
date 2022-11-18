using Newtonsoft.Json;
using SpaceXhistory.Models;

namespace SpaceXhistory;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		Teste();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void Teste()
	{
		HttpClient client = new();

        var serialized = client.GetStringAsync("https://api.spacexdata.com/v4/launches/next").Result;
		Root root = JsonConvert.DeserializeObject<Root>(serialized);
    }
}


