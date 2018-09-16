using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace TripApp.Model
{
    class PdfReader : ObservableObject
    {
        private string urlString;
        public string UrlString { get => urlString; set => Set(ref urlString, value); }
    }
}
