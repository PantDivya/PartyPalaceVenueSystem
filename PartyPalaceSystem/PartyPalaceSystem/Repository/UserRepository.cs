using Dapper;
using Microsoft.Data.SqlClient;
using PartyPalaceSystem.Models;

namespace PartyPalaceSystem.Repository
{
    public class UserRepository
    {
        /*private readonly IConfiguration _configuration;
        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }*/
        public bool AuthenticateUser(SignInModel user)
        {
            /*var conn_string = _configuration["DbString"];*/
            var conn_string = "Data Source=DESKTOP-0C6UNCS\\MSSQLSERVER01;Initial Catalog=MeroPartyPalace;Integrated Security=True;TrustServerCertificate=True;";
            var sql = $"SELECT * FROM tblUser WHERE Email = '{user.username}' AND Password = '{user.password}'";
            var users = new List<UserModel>();
            using (var connection = new SqlConnection(conn_string))
            {
                connection.Open();
                users = connection.Query<UserModel>(sql).ToList();
                return true;
            }
        }
    }
}
