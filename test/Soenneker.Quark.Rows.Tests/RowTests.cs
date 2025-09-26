using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Rows.Tests;

[Collection("Collection")]
public sealed class RowTests : FixturedUnitTest
{
    public RowTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Row is now a Razor component, so integration tests would be more appropriate
        // This test serves as a placeholder for future component testing
    }
}
