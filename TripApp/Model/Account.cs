using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace TripApp.Model
{
    class Account : ObservableObject
    {
        private string login;
        public string Login { get => login; set => Set(ref login, value); }

        private string password;
        public string Password { get => password; set => Set(ref password, value); }
    }
}
