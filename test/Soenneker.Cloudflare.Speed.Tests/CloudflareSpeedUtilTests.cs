using Soenneker.Cloudflare.Speed.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.Speed.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudflareSpeedUtilTests : HostedUnitTest
{
    private readonly ICloudflareSpeedUtil _util;

    public CloudflareSpeedUtilTests(Host host) : base(host)
    {
        _util = Resolve<ICloudflareSpeedUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
