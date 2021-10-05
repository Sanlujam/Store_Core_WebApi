using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Store.Core.Model.Auth.Request;
using Store.Core.Model.Auth.Response;

namespace Store.Core.Data.DAL
{
    public class UserDAL
    {
        public static async Task<SignInResponse> login(SignInRequest request)
        {
            SignInResponse response = new SignInResponse();

            var spRequest = new
            {
                email = request.Email,
                password = request.Password,
            };

            var query = "spr_Login";

            //var connection = new Connection.DataModelService.CreateConnection();

            using (var connection = Connection.DataModelService.CreateConnection())
            {
                response = (await connection.QueryAsync<SignInResponse>(query, param: spRequest, commandType: CommandType.StoredProcedure)).FirstOrDefault();
                return response;
            }

        }
    }
}
