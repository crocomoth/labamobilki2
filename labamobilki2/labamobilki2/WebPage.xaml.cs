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
	public partial class WebPage : ContentPage
	{
		public WebPage (string name, string link)
		{
            InitializeComponent();

            if (name != null && link != null)
            {
                Title += name;
                UserWebView.Source = new UrlWebViewSource() { Url = link };
            }
        }
	}
}