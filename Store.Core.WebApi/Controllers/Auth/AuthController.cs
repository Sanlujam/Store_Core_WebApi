using Microsoft.AspNetCore.Mvc;
using Store.Core.Model.Auth.Response;
using Store.Core.Model.Auth.Request;
using Store.Core.Business.Handlers.Auth;

namespace Store.Core.WebApi.Controllers.Auth
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult<SignUpResponse> SignUp (SignUpRequest request) 
        {
            SignUpResponse response = SignUpHandler.SignUp(request, this.Request);
            return response;
        }

        [HttpPost]
        public ActionResult<SignInResponse> SignIn(SignInRequest request)
        {
            SignInResponse response = SignInHandler.SignIn(request, this.Request);
            return response;
        }
    }
}
