
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDto
    {
        public int id { get; set; }
        public string tzUser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string HMO { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string min { get; set; }
        public  ICollection<ChildrenDto> Children { get; set; }
        //public Children[] children { get; set; }
        public UserDto()
        {

        }

    }
}
