using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
   public class UserConverters
    {
        public static User GetUserEntitiesfromDTO(UserDto user)
        {
            User u = new User()
            {
                id = user.id,
                // children=user.children,
                Date = user.Date,
                firstName = user.firstName,
                HMO = user.HMO,
                lastName = user.lastName,
                min = user.min,
                tzUser = user.tzUser

            };
            return u;
        }
        public static Children[] GetChildrenEntitiesfromDTO(UserDto user)
        {

            Children[] child = new Children[user.Children.Count()];
            int i = 0;
            User u = new User(){};
            foreach (var item in user.Children)
            {
                child[i] = new Children()
                {
                    tz = item.tz,
                    name = item.name,
                    dateBorn = item.dateBorn
                };
                i++;
            }
            

            return child;
        }

    }
}
