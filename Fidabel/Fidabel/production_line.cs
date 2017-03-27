using System;
using System.Collections.Generic;
using System.Text;

namespace Fidabel
{
    public partial class production_line
    {



        public int id_production_line { get; set; }

        public int id_location { get; set; }

        public string name { get; set; }
        public int id_company { get; set; }
        public int id_user { get; set; }
        public bool is_head { get; set; }
        public DateTime timestamp { get; set; }
        public bool is_read { get; set; }




    }
}
