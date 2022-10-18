using Newtonsoft.Json;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestSharp_Api.NewFolder
{



    namespace RestSharp.Demo.StepDefinition
    {
        [Binding]
        public sealed class CreatePostSteps
        {
            private static CreatePosts posts;
            public static string jsonBody;

            public object SharedSteps { get; private set; }

            [When(@"I create a request body with the following values")]
            public void WhenICreateARequestBodyWithTheFollowingValues(Table table)
            {
                posts = table.CreateInstance<CreatePosts>();

                var obj = new CreatePosts()
                {
                    userId = posts.userId,
                    title = posts.title,
                    body = posts.body
                };

                jsonBody = JsonConvert.SerializeObject(obj);
                Console.WriteLine(jsonBody);
            }

            [When(@"Add the serialized body to the API request")]
            public void WhenAddTheSerializedBodyToTheAPIRequest()
            {
                object p = SharedSteps.request.AddJsonBody(jsonBody);
            }
        }

        internal class CreatePosts
        {
            internal object title;
            internal object body;

            public object userId { get; internal set; }
        }
    }
}
