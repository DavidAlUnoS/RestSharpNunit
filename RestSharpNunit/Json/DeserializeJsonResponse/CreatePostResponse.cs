using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpNunit.Json.DeserializeJsonResponse
{
    public class CreatePostResponse
    {
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public string createdAt { get; set; }
    }
}
