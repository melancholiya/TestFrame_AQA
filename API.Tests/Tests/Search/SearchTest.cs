using API.Tests.ApiManagement.Authorization.Search;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using System.Net;

namespace API.Tests.Tests.Search
{
    public class SearchTest : BaseApiTest
    {
        private SearchManager _searchManager = new SearchManager();


        [Test]

        public async Task SearchTeacherByNameTest()
        {
            var getResult = await _searchManager.SearchTeachers();

            using (new AssertionScope())
            {
                getResult.StatusCode.Should().Be(HttpStatusCode.OK);
                getResult.Data.Should().NotBeNull();
            }
        }

    }
}
