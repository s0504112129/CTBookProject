using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
  public class UserBL
    {
        public static SaveUserResponse AddUser(UserDto user)
        {
           
           return new SaveUserResponse() { IsSuccessful = UserDal.AddUser(converters.UserConverters.GetUserEntitiesfromDTO(user), converters.UserConverters.GetChildrenEntitiesfromDTO(user)) };
        }
    }
}
