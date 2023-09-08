using RestSharp;
using Test_Fram.TestModel;

namespace API.Tests.ApiManagement
{
    public abstract class BaseApiManager
    {
        protected readonly string _baseUrl;
        protected static ConfigData _configData;
        protected RestClient _restClient;

        protected BaseApiManager(string baseUrl)
        {
            _baseUrl = baseUrl;
            //InitializeConfigData();
            InitializeRestClient();

        }
        static BaseApiManager()
        {
            _configData = ConfigReader.ReadDataFromJson("D:/testing/Test Fram/API.Tests/TestModel/data.json");
        }
        protected void InitializeConfigData()
        {
            _configData = ConfigReader.ReadDataFromJson("D:/testing/Test Fram/API.Tests/TestModel/data.json");
        }

        protected void InitializeRestClient()
        {
            _restClient = new RestClient(_configData.BaseUrl);
        }



    }
}
