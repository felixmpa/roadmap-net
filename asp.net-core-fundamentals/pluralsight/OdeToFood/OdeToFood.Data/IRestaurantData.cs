using System;
using OdeToFood.Core;

namespace OdeToFood.Data
{
	public interface IRestaurantData
	{
		IEnumerable<Restaurant> GetRestaurantsByName(string name);
		Restaurant GetById(int id);
		Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
		Restaurant Delete(int id);
        int GetCountOfRestaurants();
        int Commit();
	}


	public class InMemoryRestaurantData : IRestaurantData
	{
		List<Restaurant> restaurants;

		public InMemoryRestaurantData()
		{
			restaurants = new List<Restaurant>()
			{
				new Restaurant { Id = 1, Name = "Il'Pizza", Location = "Naco", Cuisine = CuisineType.Italian },
				new Restaurant { Id = 2, Name = "BamBum Food", Location = "Piantini", Cuisine = CuisineType.Indian },
				new Restaurant { Id = 3, Name = "La Catrina", Location = "Piantini", Cuisine = CuisineType.Mexican }
			};
        }

		public IEnumerable<Restaurant> GetRestaurantsByName(string name  = null)
		{
			return from r in restaurants
				   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
				   orderby r.Name
				   select r;
		}

		public Restaurant GetById(int id)
		{
			return restaurants.SingleOrDefault(r => r.Id == id);
		}

		public Restaurant Update(Restaurant updatedRestaurant)
		{
			var restaurant = restaurants.SingleOrDefault(r => r.Id == updatedRestaurant.Id);
			if(restaurant != null)
			{
				restaurant.Name = updatedRestaurant.Name;
				restaurant.Location = updatedRestaurant.Location;
				restaurant.Cuisine = updatedRestaurant.Cuisine;
			}
			return restaurant;
		}

		public Restaurant Add(Restaurant newResturant)
		{
			restaurants.Add(newResturant);
			newResturant.Id = restaurants.Max(r => r.Id) + 1;
			return newResturant;
		}


		public Restaurant Delete(int id)
		{
			var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
			if(restaurant != null)
			{
				restaurants.Remove(restaurant);
			}
			return restaurant;
		}

        public int GetCountOfRestaurants()
        {
            return restaurants.Count();
        }

        public int Commit()
		{
			return 0;
		}





	}
}

