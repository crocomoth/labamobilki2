using labamobilki2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace labamobilki2.ViewModel
{
    public class VMMain : INotifyPropertyChanged
    {
        private string _name;
        private string _shortdescr;
        private string _longDescr;
        private string _image;
        private string _bigImage;
        private string _link;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Shortdescr
        {
            get => _shortdescr;
            set
            {
                _shortdescr = value;
                NotifyPropertyChanged();
            }
            
        }

        public string LongDescr
        {
            get => _longDescr;
            set
            {
                _longDescr = value;
                NotifyPropertyChanged();
            }
        }

        public string Image
        {
            get => _image;
            set
            {
                _image = value;
                NotifyPropertyChanged();
            }
        }

        public ImageSource RealImage
        {
            get => GetImage();
            set
            {
                NotifyPropertyChanged();
            }
        }

        private string BigImage
        {
            get => _bigImage;
            set
            {
                _bigImage = value;
                NotifyPropertyChanged();
            }
        }

        private string Link
        {
            get => _link;
            set
            {
                _link = value;
                NotifyPropertyChanged();
            }
        }

        public ImageSource GetImage()
        {
            ImageSource image = ImageSource.FromResource($"labamobilki2.Images.{this.Image}.png");
            return image;
        }

        public VMMain(Item elem)
        {
            this.Name = elem.name;
            this.Image = elem.image1;
            this.Shortdescr = elem.shortdescr;
            this.LongDescr = elem.longdescr;
            this.BigImage = elem.image2;
            this.Link = elem.link;

        }

        public VMDescription GenerateDescription()
        {
            return new VMDescription(Name,Shortdescr,LongDescr,Link,BigImage);
        }
    }
}
