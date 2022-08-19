using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNunit.ClientSetUp
{
    public class ClienRestSetUp
    {
        protected RestClient client;
        protected RestRequest request;
        protected RestResponse response;

        private string mainUrl = "http://api.zippopotam.us";
        private string mainUrlPost = "https://reqres.in";
        protected void ExecuteGenericRequest(string url, Method method, object body)
        {
            response = null;
            client = new RestClient(mainUrlPost);
            request = new RestRequest(url, method);

            if (body == null)
            {
                response = client.Execute(request);
            }
            else
            {
                request = request.AddBody(body);
                response = client.Execute(request);
            }
        }

    }
}
