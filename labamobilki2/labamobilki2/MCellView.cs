using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace labamobilki2
{
    public class MCellView : ViewCell
    {
        private Image ItemImage;
        private Label Name;
        private Label ShortDescr;
        private Label LongDescr;

        public MCellView()
        {
            ItemImage = new Image();
            Name = new Label
            {
                Text = "name",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red,
                FontSize = 20
            };
            ShortDescr = new Label
            {
                Text = "short",
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Blue,
                FontSize = 20
            };
            LongDescr = new Label { Text = "description" };
            LongDescr.LineBreakMode = LineBreakMode.WordWrap;



            ItemImage.WidthRequest = 100;
            ItemImage.HeightRequest = 100;

            StackLayout cell = new StackLayout();
            cell.Orientation = StackOrientation.Horizontal;
            cell.HeightRequest = 100;

            StackLayout labelStackLayout = new StackLayout();
            labelStackLayout.Children.Add(Name);
            labelStackLayout.Children.Add(ShortDescr);
            labelStackLayout.Children.Add(LongDescr);

            cell.Children.Add(ItemImage);
            cell.Children.Add(labelStackLayout);

            View = cell;
        }

        public static readonly BindableProperty imageProperty =
            BindableProperty.Create("idImage", typeof(string), typeof(MCellView), null);

        public static readonly BindableProperty nameProperty =
            BindableProperty.Create("ItemName", typeof(string), typeof(MCellView), "");

        public static readonly BindableProperty shortDescrProperty =
            BindableProperty.Create("ItemShortDescr", typeof(string), typeof(MCellView), "");

        public static readonly BindableProperty longDescrProperty =
            BindableProperty.Create("ItemLongDescr", typeof(string), typeof(MCellView), "");

        public string idImage
        {
            get
            {
                string imageNameProperty = GetValue(imageProperty) as string;
                return $"labamobilki2.Images.{imageNameProperty}.png";
            }
            set
            {
                SetValue(imageProperty, value);
            }
        }

        public string ItemName
        {
            get { return GetValue(nameProperty) as string; }
            set { SetValue(nameProperty, value); }
        }

        public string ItemShortDescr
        {
            get { return GetValue(shortDescrProperty) as string; }
            set { SetValue(shortDescrProperty, value); }
        }

        public string ItemLongDescr
        {
            get { return GetValue(longDescrProperty) as string; }
            set { SetValue(longDescrProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                ItemImage.Source = ImageSource.FromResource(idImage);
                Name.Text = ItemName;
                ShortDescr.Text = ItemShortDescr;
                LongDescr.Text = ItemLongDescr;
            }
        }
    }
}
