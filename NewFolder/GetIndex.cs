using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharp_Api
{
    public static class GetIndex
    {
        public static RestClient client;

        public static RestRequest restRequest;

        public static string baseUrl = "https://confignepal.com";


        public static RestClient SetUrl(string endpoint)
        {
            var url=  Path.Combine(baseUrl, endpoint);
            return client = new RestClient(url);    

        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.Get);

            restRequest = Addheader("Accept", "application/json");

            return restRequest;
        }
         
    }
}
