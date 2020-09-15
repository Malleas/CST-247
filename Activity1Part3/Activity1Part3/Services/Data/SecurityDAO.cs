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

            string connectionString = "Server =.; Database = Test; Trusted_Connection = True";
            string query = @"select rtrim(USERNAME) from dbo.Users where USERNAME = 'test'"; 
            bool results = false;
           
            using (SqlConnection conncetion = new SqlConnection(connectionString))
            {
               
                SqlCommand command = new SqlCommand(query, conncetion);
                command.Connection.Open();
                SqlDataReader reader =  command.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        // check what the valu returned is
                        string value = reader.GetString(0);
                        if (reader.GetString(0).Equals(user.UserName))
                        {
                           
                            results = true;
                        }

                    }
                }
               

                
            }
            return results;
        }
    }
}