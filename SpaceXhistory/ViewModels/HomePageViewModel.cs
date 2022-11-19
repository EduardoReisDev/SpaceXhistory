using System;
using Newtonsoft.Json;
using SpaceXhistory.Helpers;
using SpaceXhistory.Models;

namespace SpaceXhistory.ViewModels
{
	public class HomePageViewModel : BaseViewModel
	{
		public Root NextLaunch { get; set; }
		public Root LastedLaunch { get; set; }

        private readonly HttpClient _client;

		public HomePageViewModel()
		{
			_client = new HttpClient();
		}

		public void GetNextLaunch()
		{
            var nextLaunchSerialized = _client.GetStringAsync(Constants.BaseUrl + "next").Result;
            NextLaunch = JsonConvert.DeserializeObject<Root>(nextLaunchSerialized);
        }

		public void GetLastedLaunch()
		{
            var lastedLaunchSerialized = _client.GetStringAsync(Constants.BaseUrl + "latest").Result;
            LastedLaunch = JsonConvert.DeserializeObject<Root>(lastedLaunchSerialized);
        }
	}
}

