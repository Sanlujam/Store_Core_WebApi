using Store.Core.Model.Auth.Response;
using Store.Core.Model.Auth.Request;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Store.Core.Business.Handlers.Auth
{
    public class SignInHandler
    {
        public static async Task<SignInResponse> SignIn(SignInRequest request, HttpRequest httpRequest)
        {
            SignInResponse response = new SignInResponse();

            try
            {
                if (ValidateRequest(request))
                {
                    response = await Data.DAL.UserDAL.login(request);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        private static bool ValidateRequest(SignInRequest request)
        {
            return true;
        }
    }
}
