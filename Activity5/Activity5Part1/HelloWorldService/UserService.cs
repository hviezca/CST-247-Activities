using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {

        List<UserModel> users = new List<UserModel>();

        public UserService()
        {
            users.Add(new UserModel(0, "Hiram", "asdf"));
            users.Add(new UserModel(1, "Sherlock", "cat"));
            users.Add(new UserModel(2, "Watson", "cat2"));
            users.Add(new UserModel(3, "Ken", "qwer"));
            users.Add(new UserModel(4, "Jimmy", "zxcv"));
            users.Add(new UserModel(5, "Alex", ";lkj"));            
        }

        public string SayHello()
        {
            return string.Format("Hello World");
        }
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public User GetObjectModel(string id)
        {
            if (Int32.Parse(id) > 0)
            {
                User user = new User();
                return user;
            }
            else
            {
                return null;
            }
        }

        public DTO GetUser(string id)
        {
            DTO dto = new DTO();

            dto.Data = users.Where(x => x.Id == Int32.Parse(id)).ToList();
            if (dto.Data.Count != 0)
            {
                dto.ErrorCode = 0;
                dto.ErrorMessage = "OK";
                return dto;
            }
            else
            {
                dto.ErrorCode = 1;
                dto.ErrorMessage = "User Does Not Exist.";
                return dto;
            }
            
        }

        public DTO GetAllUsers()
        {
            DTO dto = new DTO();
            dto.ErrorCode = 0;
            dto.ErrorMessage = "OK";
            dto.Data = users;
            return dto;
        }
    }
}
