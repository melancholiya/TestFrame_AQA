using API.Tests.ApiManagement.Authorization;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using RestSharp;
using System.Net;
using Test_Fram.TestModel;

namespace API.Tests.Tests
{
    public class BaseApiTest
    {
        protected RestClient restClient;
        protected ConfigData configData = ConfigReader.ReadDataFromJson("D:/testing/Test Fram/API.Tests/TestModel/data.json");
        private AuthorizationManager authorizationManager;

        [SetUp]
        public void SetUp()
        {
            restClient = new RestClient(configData.BaseUrl);
            authorizationManager = new AuthorizationManager();
            //GetTokenShouldReturnTest().GetAwaiter().GetResult();
        }
        [Test]
        public async Task GetTokenShouldReturnTest()
        {
            var getResult = await authorizationManager.GetTokenShouldReturn();

            using (new AssertionScope())
            {
                getResult.StatusCode.Should().Be(HttpStatusCode.Created);
                getResult.Data.Should().NotBeNull();
            }
        }
    }
}










