namespace NUnit.TestData.RepeatingTests
{
    public interface IRepeatingTestsFixture
    {
        int FixtureSetupCount { get; }
        int FixtureTeardownCount { get; }
        int SetupCount { get; }
        int TeardownCount { get; }
        int Count { get; }
    }
}
