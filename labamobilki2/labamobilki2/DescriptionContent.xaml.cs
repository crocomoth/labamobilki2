using labamobilki2.View;
using labamobilki2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace labamobilki2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DescriptionContent : ContentPage
	{

        public VMDescription Description { get; set; }


        public DescriptionContent (VMDescription mDescription)
		{
			InitializeComponent ();

            this.Description = mDescription;

            if (Description != null)
            {
                Title += Description.Name;

                var descriptionItem = new Description();

                descriptionItem.LongDescr = Description.LongDescr;
                descriptionItem.Image = ImageSource.FromResource($"labamobilki2.Images.{Description.Image2}.jpg");
                descriptionItem.ShortDescr = Description.Shordescr;
                descriptionItem.Link = Description.Link;
                descriptionItem.Name = Description.Name;

                BindingContext = descriptionItem;
            }
        }

        private async void Link_Click(object sender, EventArgs e)
        {
            if (Description.Name != null && Description.Link != null)
            {
                await Navigation.PushAsync(new WebPage(Description.Name, Description.Link));

            }
        }
    }
}