﻿using System;
using System.Collections.ObjectModel;
using XamarinFormsPresentations;

namespace XamarinFormsPresentations
{
public class MenuViewModel : BaseViewModel
	{
		ObservableCollection<MenuItem> menuItems;

		public ObservableCollection<MenuItem> MenuItems
		{
			get { return menuItems; }
			set
			{
				menuItems = value;
				OnPropertyChanged("MenuItems");
			}
		}

		public MenuViewModel()
		{
			this.menuItems = new ObservableCollection<MenuItem>();
			initMenuItems();
		}

		private void initMenuItems()
		{
			menuItems.Add(new MenuItem
			{
				Title = "Home",
				IconSource = "ic_home",
				TargetType = typeof(HomePage),
				ViewModel = new HomeViewModel() { IsInitialized = false }
			});

			menuItems.Add(new MenuItem
			{
				Title = "News",
				IconSource = "ic_news",
				TargetType = typeof(NewsPage),
				ViewModel = new NewsViewModel()
			});

			menuItems.Add(new MenuItem
			{
				Title = "Face Recognition",
				IconSource = "ic_news",
				TargetType = typeof(FacePage),
				ViewModel = new FaceViewModel()
			});

			menuItems.Add(new MenuItem
			{
				Title = "Maps",
				IconSource = "ic_news",
				TargetType = typeof(MapPage),
				ViewModel = new MapViewModel()
			});

			menuItems.Add(new MenuItem
			{
				Title = "Gallery",
				IconSource = "ic_news",
				TargetType = typeof(GalleryPage),
				ViewModel = new GalleryViewModel()
			});

			menuItems.Add(new MenuItem
			{
				Title = "Contact Us",
				IconSource = "ic_contactus",
				TargetType = typeof(ContactUsPage),
				ViewModel = new ContactUsViewModel()
			});

			menuItems.Add(new MenuItem
			{
				Title = "Flow ListView",
				IconSource = "ic_contactus",
				TargetType = typeof(FlowListViewPage),
				ViewModel = new FlowListViewModel()
			});

            menuItems.Add(new MenuItem
            {
                Title = "Shapes of Labels",
                IconSource = "ic_contactus",
                TargetType = typeof(LabelShapesPage),
				ViewModel = new BaseViewModel()
            });

            menuItems.Add(new MenuItem
            {
                Title = "QR Code",
                IconSource = "ic_contactus",
                TargetType = typeof(QrCodePage),
                ViewModel = new QrCodeViewModel()
            });
        }
	}
}
