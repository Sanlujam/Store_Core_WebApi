using Store.Core.Model.Auth.Response;
using Store.Core.Model.Auth.Request;
using Microsoft.AspNetCore.Http;
using System;

namespace Store.Core.Business.Handlers.Auth
{
    public class SignUpHandler
    {
        public static SignUpResponse SignUp(SignUpRequest request, HttpRequest httpRequest)
        {
            SignUpResponse response = new SignUpResponse();

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

        private static bool ValidateRequest(SignUpRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
