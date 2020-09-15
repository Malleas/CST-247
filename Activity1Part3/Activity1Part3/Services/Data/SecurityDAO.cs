using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Data
{
    public class SecurityDAO
    {

        public bool FindByUser(UserModel user)
        {
            string connectionString = "(localdb)\\MSSQLLocalDB";
            string userName = user.UserName;
            string password = user.Password;
            string query = "select * from dbo.Users where USERNAME = 'test'";
            using (SqlConnection conncetion = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conncetion);
                command.Connection.Open();
                var results = command.ExecuteNonQuery();
                //If results are == 1 return true, else false
                if(results.)
            }
        }
    }
}