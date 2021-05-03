﻿using Snek.Graph_Creation.Core;

namespace Snek.Graph_Creation.ViewModel
{
    class Create_Graph_ViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand EinstellungenViewCommand { get; set; }
        public RelayCommand UeberUnsCommand { get; set; }

        public object _currentView;

        public EinstellungViewModel EinstellungViewModel { get; set; }
        public HomeViewModel HomeViewModel { get; set; }
        public UeberUnsViewModel UeberUnsViewModel { get; set; }
        public object CurrentView { get { return _currentView; } set { _currentView = value; OnPropertyChanged(); } }

        public Create_Graph_ViewModel()
        {
            EinstellungViewModel = new EinstellungViewModel();
            HomeViewModel = new HomeViewModel();
            UeberUnsViewModel = new UeberUnsViewModel();

            HomeViewCommand = new RelayCommand(a => { CurrentView = HomeViewModel; });
            EinstellungenViewCommand = new RelayCommand(a => { CurrentView = EinstellungenViewCommand; });
            UeberUnsCommand = new RelayCommand(a => { CurrentView = UeberUnsCommand; });
            CurrentView = HomeViewModel;
        }
    }
}
