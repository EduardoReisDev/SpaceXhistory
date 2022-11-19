using System;
using Newtonsoft.Json;
using SpaceXhistory.Helpers;
using SpaceXhistory.Models;

namespace SpaceXhistory.ViewModels
{
	public class HomePageViewModel : BaseViewModel
	{
		public Root NextLaunch
		{
			get => _nextLaunch;
			set => SetProperty(ref _nextLaunch, value);
		}

		public Root LatestLaunch
		{
			get => _latestLaunch;
			set => SetProperty(ref _latestLaunch, value);
		}

        private readonly HttpClient _client;
		private Root _nextLaunch;
		private Root _latestLaunch;

		public HomePageViewModel()
		{
			_client = new HttpClient();
		}

		public void GetNextLaunch()
		{
            var nextLaunchSerialized = _client.GetStringAsync(Constants.BaseUrl + "next").Result;
            NextLaunch = JsonConvert.DeserializeObject<Root>(nextLaunchSerialized);
        }

		public void GetLatestLaunch()
		{
            var lastedLaunchSerialized = _client.GetStringAsync(Constants.BaseUrl + "latest").Result;
            LatestLaunch = JsonConvert.DeserializeObject<Root>(lastedLaunchSerialized);
        }
	}
}

