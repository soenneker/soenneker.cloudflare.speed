using Soenneker.Cloudflare.Speed.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Cloudflare.Speed.Tests;

[Collection("Collection")]
public sealed class CloudflareSpeedUtilTests : FixturedUnitTest
{
    private readonly ICloudflareSpeedUtil _util;

    public CloudflareSpeedUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<ICloudflareSpeedUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
