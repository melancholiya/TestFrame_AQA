using API.Tests.DTO.Requests.Authorization;
using API.Tests.DTO.Responses.Authorization;
using RestSharp;

namespace API.Tests.ApiManagement.Authorization
{
    public class AuthorizationManager : BaseApiManager
    {
        private string _token;

        public AuthorizationManager() : base(_configData.LoginUrl)
        {
        }

        public async Task<RestResponse<GetLogin>> GetTokenShouldReturn()
        {
            var req = new RestRequest(AuthorizationRoutes.TOKEN, Method.Post);
            var body = new CreateLogin
            {
                username = _configData.UserManagement.Username,
                password = _configData.UserManagement.Password
            };

            req.AddHeader("Accept", "application/json, text/plain");
            req.AddJsonBody(body);

            var response = await _restClient.ExecuteAsync<GetLogin>(req);

            _token = response.Content;
            return response;
        }

    }
}
