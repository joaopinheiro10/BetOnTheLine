using System.Collections.Generic;
using db.Model;
using MySql.Data.MySqlClient;
using Dapper;


namespace db.Services
{
    public class PersonService : IPersonService
    {
        private readonly string _connectionString;

        public PersonService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Person> GetAll()
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Person>("SELECT id, firstName, lastName, username, email FROM Person ORDER BY Name ASC");
            }
        }
    }
}