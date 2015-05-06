using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UserService.Models;

namespace UserService
{
    public class UserService : IUserService
    {
        public List<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Azure"].ConnectionString))
            {

                connection.Open();
                var command = new SqlCommand("select * from users");
                command.Connection = connection;
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User { Name = reader["Name"].ToString(), Id = (int)reader["Id"] });
                }
                return users;
            }
        }

        public void CreateUser(User user)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Azure"].ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("insert into users (name) values ('" + user.Name + "')");
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
    }
}