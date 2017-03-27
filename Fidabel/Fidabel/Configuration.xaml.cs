using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fidabel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Configuration : ContentPage
	{
		public Configuration()
		{
			InitializeComponent ();
		}

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (txtURL.Text!="")
            {
                CurrentSession.url = txtURL.Text;
                Navigation.PushModalAsync(new Login());
            }
        
        }
    }
}
