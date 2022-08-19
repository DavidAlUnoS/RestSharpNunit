using Newtonsoft.Json;
using RestSharpNunit.ClientSetUp;
using RestSharpNunit.Json.DeserializeJsonResponse;
using RestSharpNunit.Json.SerializeJsonBody;

namespace RestSharpNunit.RequestValidations
{
    public class RequestValidationMethods : ClienRestSetUp
    {
        private PlaceDetailsResponse placeDetailsResponse;
        private CreatePostResponse createPostResponse;

        internal void ValidateResponseIsJson()
        {
            ExecuteGenericRequest("nl/3825", Method.Get, null);

            placeDetailsResponse = JsonConvert.DeserializeObject<PlaceDetailsResponse>(response.Content);

            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }

        internal void ValidateResponseIsNetherlands()
        {
            ExecuteGenericRequest("nl/3825", Method.Get, null);

            placeDetailsResponse = JsonConvert.DeserializeObject<PlaceDetailsResponse>(response.Content);

            Assert.AreEqual(placeDetailsResponse.country, "Netherlands");
        }

        internal void ValidatePostExampleResponse()
        {
            ExamplePostBody examplePostBody = new ExamplePostBody
            {
                name = "Kksdmekasd",
                job = "Obrero"
            };

            ExecuteGenericRequest("/api/users", Method.Post, examplePostBody);

            createPostResponse = JsonConvert.DeserializeObject<CreatePostResponse>(response.Content);

            Assert.AreEqual("Kksdmekasd", createPostResponse.name);

            Assert.IsTrue(response.IsSuccessful);

        }
    }
}
