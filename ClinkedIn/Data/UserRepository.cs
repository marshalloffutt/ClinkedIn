using ClinkedIn.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace ClinkedIn.Data
{
    public class UserRepository
    {
        const string ConnectionString = "Server=localhost;Database=ClinkedIn;Trusted_Connection=True;";

        // Add User
        public User AddUser(string name, string password, int age, DateTime releaseDate)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var newUser = db.QueryFirstOrDefault<User>(@"
                    Insert into users (name, password, age, releaseDate
                    Output inserted.*
                    Values(@name, @password, @age, @releaseDate)",
                    new { name, password, age, releaseDate });

                if (newUser != null)
                {
                    return newUser;
                }
            }
            throw new Exception("No user created");
        }
    }
}
