using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabNavigationAdd
{
    public class ModelComments
    {
        [JsonProperty("postId")]
        public int postId { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("body")]
        public string body { get; set; }

    }
}
