using System.ComponentModel;
using ComboBoxNullValueExample.Annotations;

namespace ComboBoxNullValueExample
{
    class MainViewModel : INotifyPropertyChanged
    {
        public string SelectedMyValue { get; set; }

        public string[] MyValues
        {
            get
            {
                return new[]
                {
                    null,
                    "Пункт 1",
                    "Пункт 2",
                    "Пункт 3",
                    "Пункт 4"
                };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
