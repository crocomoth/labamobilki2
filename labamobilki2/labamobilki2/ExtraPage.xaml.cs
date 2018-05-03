using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labamobilki2.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace labamobilki2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExtraPage : ContentPage
	{
	    private ExtraPageVM viewModel { get; set; }

		public ExtraPage ()
		{
			InitializeComponent ();

            this.viewModel = new ExtraPageVM();

		    BindingContext = viewModel;
		}
	}
}