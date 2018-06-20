using NUnit.Framework;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace Microservice.Generic.IntegrationTests.v2
{
    public class ValuesApiTests
    {
		HttpClient _client { get; set; }

		[SetUp]
		public void Setup()
		{
			WebApplicationFactory<Startup> factory = new WebApplicationFactory<Startup>();
			_client = factory.CreateClient();

		}

		[Test]
		public async Task GetAll_Returns_SuccessResponse()
		{
			// Act
			var response = await _client.GetAsync("/v2/values");

			// Assert
			response.EnsureSuccessStatusCode(); // Status Code 200-299
			Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
		}
	}
}
