using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class UserDal
    {
        public static bool AddUser(User u,Children[]children)
        {
            try
            {
                using (MyContectsContext ctx = new MyContectsContext())
                {
                    foreach (var item in children)
                    {
                        ctx.Children.Add(item);
                    }

                    ctx.User.Add(u);
                    ctx.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
               // return false;
                throw e;
            }
        }
    }
}
