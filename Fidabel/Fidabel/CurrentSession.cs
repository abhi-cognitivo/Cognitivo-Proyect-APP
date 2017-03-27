using System;
using System.Collections.Generic;
using System.Text;

namespace Fidabel
{
   public static class CurrentSession
    {
         public static int ProductionLine { get; set; }
        public static int production_order { get; set; }
        public static int production_order_detail { get; set; }
        public static string url { get; set; }

    }
}
