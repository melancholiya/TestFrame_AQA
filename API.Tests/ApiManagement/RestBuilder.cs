using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;


namespace API.Tests.ApiManagement
{
    public class RestBuilder
    {
        private RestRequest _restRequest;
        private readonly string _baseUri;
        private readonly JsonSerializerSettings _jsonSerializerSettings;

        private RestClient GetRestClient()
        {
            var restClient = new RestClient(_baseUri);

            return restClient;
        }

        public RestBuilder(string baseUri)
        {
            _baseUri = baseUri;
            _restRequest = new RestRequest();
            _jsonSerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DefaultValueHandling = DefaultValueHandling.Include,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public RestBuilder AddHeader(string key, string value)
        {
            _restRequest.AddHeader(key, value);
            return this;
        }

        public RestBuilder AddAuthorizationHeader(string token)
        {
            return AddHeader("Authorization", $"Bearer {token}");
        }

        public RestBuilder Method(Method method)
        {
            _restRequest.Method = method;
            return this;
        }

        public RestBuilder ToEndPoint(string resource)
        {
            _restRequest.Resource = resource;
            return this;
        }

        public RestBuilder AddParameter(string param, string value)
        {
            _restRequest.AddParameter(param, value);
            return this;
        }

        public RestBuilder AddBody(object body)
        {
            _restRequest.AddJsonBody(body);
            return this;
        }
        //public async Task<RestResponse<T>> ExecuteAsync<T>(RestClient restClient) where T : new()
        //{
        //    return await restClient.ExecuteAsync<T>(GetRestClient());
        //}


    }
}
