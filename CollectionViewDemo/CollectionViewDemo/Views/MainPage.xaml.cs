﻿using CollectionViewDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			//collectionView.ItemsSource = new string[]
			//{
			//	"Can",
			//	"Sausage",
			//	"Jam",
			//	"Juice",
			//	"Bread",
			//	"Chicken",
			//	"Chips",
			//	"Eggs"
			//};
			this.BindingContext = new MainPageViewModel();
		}
	}
}
