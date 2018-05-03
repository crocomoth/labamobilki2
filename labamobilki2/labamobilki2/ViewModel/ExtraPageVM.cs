using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using labamobilki2.Annotations;

namespace labamobilki2.ViewModel
{
    public class ExtraPageVM : INotifyPropertyChanged

    {

        public string _text;

        public string LabelText
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        public string EntryText
        {
            get => _text;
            set
            {
                this.LabelText = value;
                this._text = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
