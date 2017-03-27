using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fidabel
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            RestService RestService = new Fidabel.RestService();
            dataGridline.ItemsSource = RestService.GetLine("http://" + CurrentSession.url + "/api/production_line");

        }

        private void DataGrid_SelectionChanged(object sender, Syncfusion.SfDataGrid.XForms.GridSelectionChangedEventArgs e)
        {
            production_line production_line = dataGridline.SelectedItem as production_line;
            CurrentSession.ProductionLine = production_line.id_production_line;
            Navigation.PushModalAsync(new ProductionOrder(CurrentSession.ProductionLine));
        }
    }
}
