using Dapper;
using DemoSecurity_DAL.Entities;
using DemoSecurity_DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSecurity_DAL.Services
{
    public class UserService : IUserRepository
    {
        private readonly SqlConnection _connection;
        public UserService(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Register(string nickname, string password, string email)
        {
            string sql = "INSERT INTO Users (Nickname, Email, Passwd) " +
                "VALUES (@nickname, @email, @password)";

            _connection.Execute(sql, new { nickname, email, password });
        }

        public User Login(string email)
        {
            string sql = "SELECT * FROM Users WHERE Email = @email";

            return _connection.QueryFirst<User>(sql, new { email });
        }

        public string CheckPassword(string email)
        {
            string sql = "SELECT Passwd FROM Users WHERE Email = @email";
            return _connection.QueryFirst<string>(sql, new { email });
        }

        public IEnumerable<User> GetUsers()
        {
            return _connection.Query<User>("SELECT * FROM Users");
        }
    }
}
