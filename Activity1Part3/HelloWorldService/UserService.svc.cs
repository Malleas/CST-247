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
        Random random = new Random();
        List<UserModel> userList = new List<UserModel>();
        public UserService()
        {
            UserModel u1 = new UserModel(1, "Bob", "password1");
            UserModel u2 = new UserModel(2, "Jim", "password1");
            UserModel u3 = new UserModel(3, "Sue", "password1");


            userList.Add(u1);
            userList.Add(u2);
            userList.Add(u3);
        }

        private static List<int> GetRandomScores(Random r)
        {
            List<int> listOfScores = new List<int>();
            for (int i = 0; i < r.Next(10); i++)
            {
                listOfScores.Add(r.Next(100));
            }
            return listOfScores;
        }

        public UserDTO GetAllUsers()
        {
            UserDTO userDTO = new UserDTO();
            userDTO.MessageCode = 0;
            userDTO.MessageText = "OK";
            userDTO.UserList = userList;
            return userDTO;
            
        }

        public string GetData(string value)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetuserById(string id)
        {
            UserDTO userDTO = new UserDTO();
            

            if(int.Parse(id) < userList.Count)
            {
                userDTO.MessageCode = 0;
                userDTO.MessageText = "OK";
                List<UserModel> user = userList.Where(x => x.Id.Equals(int.Parse(id))).ToList();
                userDTO.UserList = user;
                return userDTO;
            }
            else
            {
                userDTO.MessageCode = 1;
                userDTO.MessageText = "User ID not found";
                return userDTO;
            }
            

        }

        public UserDTO GetUsersByName(string name)
        {
            throw new NotImplementedException();
        }

        public string SayHello()
        {
            return "Hello World";
        }
    }
}
