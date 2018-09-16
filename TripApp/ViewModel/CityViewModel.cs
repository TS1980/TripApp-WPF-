using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using TripApp.Model;
using System.Collections.ObjectModel;
using TripApp.Services;
using GalaSoft.MvvmLight.Command;

namespace TripApp.ViewModel
{
    class CityViewModel : ViewModelBase
    {
        private string input = "";
        public string Input { get => input; set => Set(ref input, value); }

        private City selected;
        public City Selected
        {
            get => selected;
            set
            {
                Set(ref selected, value);
                var city = cityAdd.FullInfo(Selected.CityName);
                Selected.CountryId = city.CountryId;
                Selected.ContinentCode = city.ContinentCode;
            }
        }

        private ObservableCollection<City> list = new ObservableCollection<City>();
        public ObservableCollection<City> List { get => list; set => Set(ref list, value); }

        private readonly ICityAdd cityAdd;

        public CityViewModel(ICityAdd cityAdd)
        {
            this.cityAdd = cityAdd;
        }

        private RelayCommand searchCommand;
        public RelayCommand SearchCommand
        {
            get => searchCommand ?? (searchCommand = new RelayCommand(
                () => List = new ObservableCollection<City>(cityAdd.Search(Input))
            ));
        }
    }
}

