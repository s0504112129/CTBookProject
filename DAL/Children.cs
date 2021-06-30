using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class Children
  {
        [Key]
        public int id { get; set; }
        public string tz { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> dateBorn { get; set; }
        public string tzUser { get; set; }

        public virtual User User { get; set; }
    }
}
