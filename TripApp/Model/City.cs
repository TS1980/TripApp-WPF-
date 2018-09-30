using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace TripApp.Model
{
    class City : ObservableObject
    {
        private string cityName;
        public string CityName { get => cityName; set => Set(ref cityName, value); }

        private string countryId;
        public string CountryId { get => countryId; set => Set(ref countryId, value); }

        private string lon;
        public string Lon { get => lon; set => Set(ref lon, value); }

        private string lat;
        public string Lat { get => lat; set => Set(ref lat, value); }

        //private string continentCode;
        //public string ContinentCode { get => continentCode; set => Set(ref continentCode, value); }

        //private string poster;
        //public string Poster { get => poster; set => Set(ref poster, value); }
    }
}
