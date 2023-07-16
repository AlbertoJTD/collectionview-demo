using CollectionViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewDemo.ViewModels
{
	public class MainPageViewModel
	{
        public ObservableCollection<Product> Products { get; set; }

        public MainPageViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "Yogurt",
                    Price = 60.0m,
                    Image = "yogurt.png",
                    HasOffer = false
                },
				new Product
				{
					Name = "Tomato",
					Price = 60.0m,
					Image = "tomato.png",
					HasOffer = true,
					OfferPrice = 40.0m
				},
				new Product
				{
					Name = "Apple",
					Price = 80.0m,
					Image = "apple.png",
					HasOffer = false,
					OfferPrice = 0.0m
				},
				new Product
				{
					Name = "Banana",
					Price = 50.0m,
					Image = "banana.png",
					HasOffer = true,
					OfferPrice = 30.0m
				},
				new Product
				{
					Name = "Orange",
					Price = 70.0m,
					Image = "orange.png",
					HasOffer = false,
					OfferPrice = 0.0m
				},
				new Product
				{
					Name = "Cucumber",
					Price = 40.0m,
					Image = "cucumber.png",
					HasOffer = true,
					OfferPrice = 25.0m
				},
				new Product
				{
					Name = "Grapes",
					Price = 90.0m,
					Image = "grapes.png",
					HasOffer = false,
					OfferPrice = 0.0m
				},
				new Product
				{
					Name = "Watermelon",
					Price = 120.0m,
					Image = "watermelon.png",
					HasOffer = true,
					OfferPrice = 80.0m
				},
				new Product
				{
					Name = "Pineapple",
					Price = 100.0m,
					Image = "pineapple.png",
					HasOffer = true,
					OfferPrice = 70.0m
				},
				new Product
				{
					Name = "Pear",
					Price = 75.0m,
					Image = "pear.png",
					HasOffer = false,
					OfferPrice = 0.0m
				}
			};
        }
    }
}
