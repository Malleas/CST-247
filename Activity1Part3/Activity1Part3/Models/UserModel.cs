using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Activity1Part3.Models
{
    [DataContract]
    public class UserModel
    {
        public UserModel(int id, string userName, string password)
        {
            UserName = userName;
            Password = password;
            Id = id;
        }

        [Required]
        [DisplayName("User Name")]
        [StringLength(20, MinimumLength =4)]
        [DefaultValue("")]
        [DataMember]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength =4)]
        [DefaultValue("")]
        [DataMember]
        public string Password { get; set; }

        public int Id { get; set; }
    }
}