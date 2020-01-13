using ClassLib;
using Xunit;

namespace ClassLibTests
{
    public class JsonTests
    {
        [Fact]
        public void Serializer_Works()
        {
            var json = Json.Serialize(new
            {
                Name = "Ivan",
                Surname = "Sanz",
            });

            Assert.Equal(
                @"{""Name"":""Ivan"",""Surname"":""Sanz""}",
                json);
        }
    }
}
