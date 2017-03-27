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
	public partial class ProductionOrderDetail : ContentPage
	{
		public ProductionOrderDetail (int OrderId)
		{
            InitializeComponent();
            RestService RestService = new Fidabel.RestService();
            dataGridorderdetail.ItemsSource = RestService.GetOrderDetailList("http://" + CurrentSession.url + "/api/production_order_detail/" + OrderId);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductionOrder(CurrentSession.ProductionLine));
        }

        private void DataGrid_SelectionChanged(object sender, Syncfusion.SfDataGrid.XForms.GridSelectionChangedEventArgs e)
        {
            production_order_detail production_order_detail = dataGridorderdetail.SelectedItem as production_order_detail;
            CurrentSession.production_order_detail = production_order_detail.id_order_detail;
            Navigation.PushModalAsync(new ProductionOrderEdit(CurrentSession.production_order_detail));
        }
    }
}
