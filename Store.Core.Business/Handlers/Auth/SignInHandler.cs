using Store.Core.Model.Auth.Response;
using Store.Core.Model.Auth.Request;
using Microsoft.AspNetCore.Http;
using System;

namespace Store.Core.Business.Handlers.Auth
{
    public class SignInHandler
    {
        public static SignInResponse SignIn(SignInRequest request, HttpRequest httpRequest)
        {
            SignInResponse response = new SignInResponse();

            try
            {
                if (ValidateRequest(request))
                {

                }
            }
            catch (Exception ex)
            {
            }

            return response;
        }

        private static bool ValidateRequest(SignInRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
