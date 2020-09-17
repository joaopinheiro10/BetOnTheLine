using System.Data;
using System.Threading.Tasks;
using MySqlConnector;
using blogPostApi;

namespace blogPostAPI.Models
{
    public class BlogPost
    {

         public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string username { get; set; }

        public string email { get; set; }

        public string password { get; set; }
        
        internal AppDb Db { get; set; }

        public BlogPost()
        {
        }

        internal BlogPost(AppDb db)
        {
            Db = db;
        }

        public async Task InsertAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"INSERT INTO `Blogpost` (`firstName`, `lastName`,`username`,`email`,`password`) VALUES (@firstName, @lastName, @username, @email, @password);";
            BindParams(cmd);
            await cmd.ExecuteNonQueryAsync();
            Id = (int) cmd.LastInsertedId;
        }

        public async Task UpdateAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"UPDATE `Blogpost` SET `firstName` = @firstName, `lastName` = @lastname, `username` = @username, `email` = @email, `password` = @firstName  WHERE `Id` = @id;";
            BindParams(cmd);
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM `BlogPost` WHERE `Id` = @id;";
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        private void BindId(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@id",
                DbType = DbType.Int32,
                Value = Id,
            });
        }

        private void BindParams(MySqlCommand cmd)
        {
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@firstName",
                DbType = DbType.String,
                Value = firstName,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@lastName",
                DbType = DbType.String,
                Value = lastName,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@username",
                DbType = DbType.String,
                Value = username,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@email",
                DbType = DbType.String,
                Value = email,
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@password",
                DbType = DbType.String,
                Value = password,
            });
        }
    }
}