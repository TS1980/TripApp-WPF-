using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripApp.Model;

namespace TripApp.Services
{
    interface ICityAdd
    {
        IEnumerable<City> Search(string name);
        City FullInfo(string id);
    }
}
