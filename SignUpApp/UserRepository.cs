using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SignUpApp
{
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(SignUpApp.Properties.Resources.InsertUser, new
                {
                    UserName = user.UserName,
                    FullName = user.FullName,
                    Email = user.Email,
                    Address = user.Address,
                    Password = user.Password
                });

                return result > 0;


            }
        }
    }
}

