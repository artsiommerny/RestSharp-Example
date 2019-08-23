using System.Linq;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestTests.LocationResponses;

namespace RestTests
{
    public class PropertiesOfGetTest
    {
        [TestFixture]
        public class StackOverflowTests
        {
            [TestCase(0, ".net", "asp.net", "asp.net-mvc", "c#", "coreclr", "entity-framework", "linq", "visual-studio",
                "wcf", "wpf", "xamarin")]
            [TestCase(1, "homoiconicity", "jit", "json", "lisp", "rebol", "red")]
            public void CheckTags(int numberOfRoom, params string[] tagsLists)
            {
                var client = new RestClient("https://stackoverflow.com/api/");
                var secondPartOfUrl = "recent-chat?tags=.net%20json%20vb.net%20rest%20restsharp&_=1566391825524";
                var request = new RestRequest(secondPartOfUrl, Method.GET);

                var response = client.Execute<Room>(request);
                var globalObject = JsonConvert.DeserializeObject<RootObject>(response.Content);

                var tags = globalObject.Rooms.ElementAt(numberOfRoom).Tags;
                Assert.That(tags, Is.EquivalentTo(tagsLists));
            }
        }
    }
}