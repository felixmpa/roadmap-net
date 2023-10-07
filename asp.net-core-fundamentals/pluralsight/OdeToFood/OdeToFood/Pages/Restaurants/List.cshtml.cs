using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;
using OdeToFood.Core;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Pages.Restaurants
{
	public class ListModel : PageModel
	{

		private readonly IConfiguration config;
		private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
		public IEnumerable<Restaurant> Restaurants { get; set; }

		[BindProperty(SupportsGet = true)]
		public string SearchTermn { get; set; }

		public ListModel(IConfiguration config, IRestaurantData restaurantData)
		{
			this.config = config;
			this.restaurantData = restaurantData;
		}

		public void OnGet()
		{
			Message = config["Message"];
			Restaurants = restaurantData.GetRestaurantsByName(SearchTermn);

		}
	}
}

