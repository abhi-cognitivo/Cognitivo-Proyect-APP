using System;

namespace Fidabel
{
    public class production_order_detail
    {

        public int id_order_detail { get; set; }
        public int id_production_order { get; set; }
        public int? id_project_task { get; set; }
        public int id_item { get; set; }
        public int? movement_id { get; set; }
        public string name { get; set; }
        public decimal quantity { get; set; }
        public int status { get; set; }
        public string code { get; set; }
        public bool is_input { get; set; }
        public DateTime trans_date { get; set; }
        public DateTime? start_date_est { get; set; }
        public DateTime? end_date_est { get; set; }
        public int id_company { get; set; }
        public int id_user { get; set; }
        public bool is_head { get; set; }
        public DateTime timestamp { get; set; }
        public bool is_read { get; set; }
        public int? parent_id_order_detail { get; set; }
        public decimal completed { get; set; }
        public int? id_item_type { get; set; }
        public decimal quantity_execustion { get; set; }

     
    }
}