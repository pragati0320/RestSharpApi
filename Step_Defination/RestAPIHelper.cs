using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharp_Api.NewFolder
{
    public static class APIHelper
    {

        public static RestClient client;

        public static RestRequest restRequest;

        public static string baseUrl = "https://httpbin.org/get";

        public static RestClient SetUrl(string endpoint)
        {
            var url = baseUrl + endpoint;
            return client = new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.Get);

            restRequest.AddHeader("Accept", "application/json");

            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }

    }
}
