using Amazon.Lambda.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace UCLA.EA.Lambda
{
    public class MyCoolHandlerTest : MyCoolHandler
    {
        // xunit tests
        [Fact]
        public async void DemonstrationTest()
        {
            Response response = await (new MyCoolHandler()).Hello(new Request("x","y","z"), null);

            Assert.NotNull(response);
        }
    }
}
