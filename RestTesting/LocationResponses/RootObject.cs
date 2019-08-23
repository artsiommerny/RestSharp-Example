using System.Collections.Generic;
using Newtonsoft.Json;

namespace RestTests.LocationResponses
{
    public class RootObject
    {
        public int ActiveUsers { get; set; }
        public int ActiveRooms { get; set; }
        [JsonProperty("rooms")] public List<Room> Rooms { get; set; }
    }
}