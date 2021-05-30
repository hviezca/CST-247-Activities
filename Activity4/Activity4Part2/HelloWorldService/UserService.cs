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
            users.Add(new UserModel() { Id = 0, Username = "Hiram", Password = "asdf" });
            users.Add(new UserModel() { Id = 1, Username = "Sherlock", Password = "cat" });
            users.Add(new UserModel() { Id = 2, Username = "Watson", Password = "cat2" });
            users.Add(new UserModel() { Id = 3, Username = "Ken", Password = "qwer" });
            users.Add(new UserModel() { Id = 4, Username = "Jimmy", Password = "zxcv" });
            users.Add(new UserModel() { Id = 5, Username = "Alex", Password = ";lkj" });            
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
