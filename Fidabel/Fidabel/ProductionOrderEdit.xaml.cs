using Newtonsoft.Json;
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
	public partial class ProductionOrderEdit : ContentPage
	{
        production_order_detail production_order_detailList;

        public ProductionOrderEdit(int id_order_detail)
		{
            InitializeComponent ();
            RestService RestService = new Fidabel.RestService();
          production_order_detailList=RestService.GetOrderDetail("http://" + CurrentSession.url + "/api/production_order_detail/show/" + id_order_detail);
            if (production_order_detailList!=null)
            {
                lblname.Text = production_order_detailList.name;
                txtquantity.Text = production_order_detailList.quantity.ToString();
            }
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductionOrderDetail(CurrentSession.production_order));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            if (production_order_detailList != null)
            {
                production_order_detailList.quantity = Convert.ToDecimal(txtquantity.Text);
                RestService RestService = new Fidabel.RestService();
                var production_order_detail_Json = JsonConvert.SerializeObject(production_order_detailList);
                
             int flag= RestService.PostData(production_order_detail_Json, "http://" + CurrentSession.url + "/api/production_order_detail/edit");
                if (flag==0)
                {
                    Navigation.PushModalAsync(new ProductionOrderDetail(CurrentSession.production_order));
                }
                else
                {
                    lblerror.Text = "Something is Wrong";
                }
            }
        }
    }
}
