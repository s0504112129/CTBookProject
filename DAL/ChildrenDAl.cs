using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ChildrenDAl
    {
        public static void AddChildren(Children c)
        {
            try
            {

                using (MyContectsContext ctx = new MyContectsContext())
                {
                    ctx.Children.Add(c);
                    ctx.SaveChanges();
                }

            }
            catch (Exception e)
            {
                throw e;

            }
        }
    }
}
