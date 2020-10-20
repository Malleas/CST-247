using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HelloWorldService
{
    [DataContract]
    public class UserDTO
    {
        [DataMember]
        public List<UserModel> UserList { get; set; }
        [DataMember]
        public int MessageCode { get; set; }
        [DataMember]
        public string MessageText { get; set; }
    }
}