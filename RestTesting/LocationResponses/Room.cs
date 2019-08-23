using System.Collections.Generic;
using Newtonsoft.Json;

namespace RestTests.LocationResponses
{
    public class Room
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("id")] public int Id { get; set; }

        [JsonProperty("lastPost")] public int LastPost { get; set; }

        [JsonProperty("tags")] public List<string> Tags { get; set; }

        [JsonProperty("singleImage")] public bool SingleImage { get; set; }

        [JsonProperty("messages")] public List<Message> Messages { get; set; }

        [JsonProperty("users")] public List<User> Users { get; set; }
    }
}