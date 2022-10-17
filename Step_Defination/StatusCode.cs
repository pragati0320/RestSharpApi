using NUnit.Framework;
using RestSharp;

namespace RestSharp_Api.NewFolder
{
    public class StatusCode
    {
        public class Tests
        {
            public void CodeTest()
            {
                //create a rest client connection
                RestClient client = new RestClient("https://jsonplaceholder.typicode.com/users");

                //create a GET Request
                RestRequest request = new RestRequest("1", Method.Get);

                //Get the response
                IRestResponse response = (IRestResponse)client.Execute(request);

                //check the status code of response
                Assert.That(
                    ResponseStatus.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.Ok));
            }
        }
    }
}