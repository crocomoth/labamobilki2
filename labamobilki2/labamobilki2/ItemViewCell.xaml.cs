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
	public partial class ItemViewCell : ViewCell
	{
        public Label Name { get; set; }
        public Label ShortDescr { get; set; }
        public Label LongDescr { get; set; }
        public Image Image { get; set; }

        public ItemViewCell ()
		{
		}
	}
}