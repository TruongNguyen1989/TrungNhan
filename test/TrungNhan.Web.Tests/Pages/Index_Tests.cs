using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TrungNhan.Pages
{
    public class Index_Tests : TrungNhanWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
