using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OpenLiveWriter.HtmlEditor
{
    public class AcronymFormViewModel : INotifyPropertyChanged
    {
        private string _definition;
        private string _acronym;

        public string Acronym
        {
            get { return _acronym; }
            set
            {
                if (_acronym != value)
                {
                    _acronym = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Definition
        {
            get { return _definition; }
            set
            {
                if (_definition != value)
                {
                    _definition = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}