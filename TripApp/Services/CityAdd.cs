using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TripApp.Model;

namespace TripApp.Services
{
    class CityAdd 
    {
        public IEnumerable<City> Search(string city)
        {
            WebClient webClient = new WebClient();
            var json = webClient.DownloadString($"http://www.geonames.org/advanced-search.html?q={city}");
            dynamic data = JsonConvert.DeserializeObject(json);
            var list = new List<City>();
            foreach (var item in data.Search)
            {
                list.Add(new City
                {
                    CityName = item.Title.ToString(),
                    CountryId = item.imdbID.ToString()
                });
            }
            return list;
        }

        public City FullInfo(string das_city)
        {
            WebClient webClient = new WebClient();
            var json = webClient.DownloadString($"http://www.geonames.org/advanced-search.html?q={das_city}");
            dynamic data = JsonConvert.DeserializeObject(json);
            var city = new City
            {
                CityName = data.q.ToString(),
                CountryId = data.country.ToString(),
                ContinentCode = data.ContinentCode.ToString(),
                Poster = data.Image.ToString()
            };
            return city;
        }
    }
}
