using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using TripApp.Model;
using System.Collections.ObjectModel;
using TripApp.Services;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;

namespace TripApp.ViewModel
{
    class PdfViewModel : ViewModelBase
    {
        private ObservableCollection<PdfReader> tickets = new ObservableCollection<PdfReader>();
        public ObservableCollection<PdfReader> Tickets
        {
            get => tickets;
            set => Set(ref tickets, value);
        }

        private string input = "";
        public string Input
        {
            get => input;
            set => Set(ref input, value);
        }

        private PdfReader selected;
        public PdfReader Selected
        {
            get => selected;
            set
            {
                Set(ref selected, value);
                var ticket = Selected.UrlString;
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get => addCommand ?? (addCommand = new RelayCommand(
                () => Tickets.Add(new PdfReader { UrlString = Input })
            ));
        }
    }
}
