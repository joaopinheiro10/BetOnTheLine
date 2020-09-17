using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySqlConnector;
using blogPostApi;
using blogPostAPI.Models;

namespace blogPostAPI
{
    public class BlogPostQuery
    {
        public AppDb Db { get; }

        public BlogPostQuery(AppDb db)
        {
            Db = db;
        }

        public async Task<BlogPost> FindOneAsync(int id)
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT  `Id`, `firstname`, `lastname`,`username`,`email`, `password` FROM `BlogPost` WHERE `Id` = @id";
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@id",
                DbType = DbType.Int32,
                Value = id,
            });
            var result = await ReadAllAsync(await cmd.ExecuteReaderAsync());
            return result.Count > 0 ? result[0] : null;
        }

        public async Task<List<BlogPost>> LatestPostsAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT `Id`, `firstname`, `lastname`,`username`,`email`, `password`   FROM `BlogPost` ORDER BY `Id` DESC LIMIT 10;";
            return await ReadAllAsync(await cmd.ExecuteReaderAsync());
        }

        public async Task DeleteAllAsync()
        {
            using var txn = await Db.Connection.BeginTransactionAsync();
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM `BlogPost`";
            await cmd.ExecuteNonQueryAsync();
            await txn.CommitAsync();
        }

        private async Task<List<BlogPost>> ReadAllAsync(DbDataReader reader)
        {
            var posts = new List<BlogPost>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var post = new BlogPost(Db)
                    {
                        Id = reader.GetInt32(0),
                        firstName = reader.GetString(1),
                        lastName = reader.GetString(2),
                        username = reader.GetString(3),
                        email = reader.GetString(4),
                        password = reader.GetString(5),
                    };
                    posts.Add(post);
                }
            }
            return posts;
        }
    }
}