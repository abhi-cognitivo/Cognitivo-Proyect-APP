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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            RestService RestService = new Fidabel.RestService();
            string Msg = RestService.GetLogin("http://" + CurrentSession.url + "/api/login/" + txtuser.Text + "/" + txtpassword.Text);
            if (Msg.ToLower()=="[true]")
            {
                Navigation.PushModalAsync(new MainPage());
            }
        }
    }
}
