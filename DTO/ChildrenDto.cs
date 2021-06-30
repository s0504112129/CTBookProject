using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ChildrenDto
   {
        public int id { get; set; }
        public string tz { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> dateBorn { get; set; }

        public string tzUser { get; set; }
    }
}
