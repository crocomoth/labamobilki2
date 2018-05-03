using labamobilki2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace labamobilki2.ViewModel
{
    public class VMDescription : INotifyPropertyChanged
    {
        private string _name;
        private string _shortDescr;
        private string _longDescr;
        private string _link;
        private string _image2;

        public VMDescription(string name,string shortDescr,string longDescr,string link,string image2)
        {
            this.Name = name;
            this.ShortDescr = shortDescr;
            this.LongDescr = longDescr;
            this.Image2 = image2;
            this.Link = link;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
            
        }

        public string ShortDescr
        {
            get => _shortDescr;
            set
            {
                _shortDescr = value;
                OnPropertyChanged();
            }
        }

        public string LongDescr
        {
            get => _longDescr;
            set
            {
                _longDescr = value;
                OnPropertyChanged();
            }
        }

        public string Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged();
            }
        }

        public string Image2
        {
            get => _image2;
            set
            {
                _image2 = value;
                OnPropertyChanged();
            }
        }

        public ImageSource RealImage
        {
            get => GetImage();
            set
            {
                OnPropertyChanged();
            }
        }

        public ImageSource GetImage()
        {
            ImageSource image = ImageSource.FromResource($"labamobilki2.Images.{this.Image2}.jpg");
            return image;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
