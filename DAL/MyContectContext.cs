using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
   public class MyContectsContext:DbContext
   {
        public MyContectsContext() : base("name=ShoshiSilverstein") {}
         
        public virtual DbSet<Children> Children { get; set; }
        public virtual DbSet<User> User { get; set; }

    }
}
