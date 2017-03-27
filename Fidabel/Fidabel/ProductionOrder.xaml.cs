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
    public partial class ProductionOrder : ContentPage
    {
        public ProductionOrder(int Lineid)
        {
            InitializeComponent();
            RestService RestService = new Fidabel.RestService();
            dataGridorder.ItemsSource = RestService.GetOrder("http://" + CurrentSession.url + "/api/production_order/" + Lineid);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        private void DataGrid_SelectionChanged(object sender, Syncfusion.SfDataGrid.XForms.GridSelectionChangedEventArgs e)
        {
            production_order production_order = dataGridorder.SelectedItem as production_order;
            CurrentSession.production_order_detail = production_order.id_production_order;
            Navigation.PushModalAsync(new ProductionOrderDetail(CurrentSession.production_order_detail));
        }
    }
}
