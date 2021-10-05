using Store.Core.Model.BusinessEntity;

namespace Store.Core.Model.Auth.Response
{
    public class SignInResponse : BaseResponse
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string password { get; set; }
    }
}
