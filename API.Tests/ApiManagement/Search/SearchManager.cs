using API.Tests.DTO.Requests.Search;
using API.Tests.DTO.Responses.Search;
using RestSharp;

namespace API.Tests.ApiManagement.Authorization.Search
{
    public class SearchManager : BaseApiManager
    {
        public SearchManager() : base(_configData.TeachersUrl) { }


        public async Task<RestResponse<SearchTeachersResponse>> SearchTeachers()
        {
            var req = new RestRequest(SearchRoutes.TOKEN, Method.Get);
            var body = new SearchTeachersByName
            {
                teachername = _configData.TeacherManagement.TeacherName
            };
            req.AddHeader("Accept", "application/json, text/plain");
            //req.AddHeader("Autho/", "application/json, text/plain");
            req.AddJsonBody(body);

            var response = await _restClient.ExecuteAsync<SearchTeachersResponse>(req);

            return response;
        }





    }
}
