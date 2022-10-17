using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RestSharp_Api.NewFolder
{



    namespace RestSharp.Demo.StepDefinition
    {
        [Binding]
        public sealed class CreateEmployee
        {
            private static Create new_emloyee;
            string jsonBody;

            [When(@"I create a request body with the following values")]
            public void WhenICreateRequestBodyWithFollowingValues(Table table)
            {
                new_emloyee = table.CreateInstance<Create>();
                var obj = new Create()
                {
                    name = new_emloyee.name,
                    salary = new_emloyee.salary,
                    age = new_emloyee.age
                };
                JsonSerializer serializer = new JsonSerializer();
                jsonBody = serializer.Serialize(obj);
            }

            [When(@"Add the serialized body to the API request")]
            public void WhenAddTheCreatedBodyToTheAPIRequest()
            {
                SharedSteps.request.AddJsonBody(jsonBody);
            }
        }

        internal class Create
        {
            internal object name;
            internal object salary;
            internal object age;
        }
    }
}
