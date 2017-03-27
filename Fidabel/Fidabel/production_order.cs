using System;
using System.Collections.Generic;
using System.Text;

namespace Fidabel
{
    public partial class production_order
    {



        public int id_production_order { get; set; }

        public int id_production_line { get; set; }
        public int? id_weather { get; set; }
        public int? id_project { get; set; }
        public int id_branch { get; set; }
        public int id_terminal { get; set; }
        public int? id_range { get; set; }
        public string work_number { get; set; }
        public int? project_cost_center { get; set; }
        public int status { get; set; }
        public string name { get; set; }
        public string barcode { get; set; }
        public DateTime trans_date { get; set; }
        public DateTime? start_date_est { get; set; }
        public DateTime? end_date_est { get; set; }
        public int? type { get; set; }
        public int id_company { get; set; }
        public int id_user { get; set; }
        public bool is_head { get; set; }
        public DateTime timestamp { get; set; }
        public bool is_read { get; set; }
        public bool is_archived { get; set; }
        public decimal completed { get; set; }



    }
}
