using labamobilki2.Model;
using labamobilki2.Parsers;
using labamobilki2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace labamobilki2
{
    public partial class MainPage : ContentPage
    {
        public VMMainList MainList { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            var jsonParser = new JSONParser();


            MainList = jsonParser.GetData();

            this.BindingContext = MainList.Elements;
        }

        private async void ItemListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            VMMain selectedItem = e.Item as VMMain;
            VMDescription description = selectedItem.GenerateDescription();
            if (selectedItem != null)
            {
                await Navigation.PushAsync(new DescriptionContent(description));
            }

            ItemListView.SelectedItem = null;
        }
    }
}
