namespace CustomerPreferenceCentre.Tests.Helpers
{
    public class TestHelpers
    {
        /// <summary>
        /// Returns a 'reasonable' amount of days to test a range of dates over.
        /// </summary>
        /// <remarks>We choose a number that is more than weekly/monthly but not too performance degrading for the test.</remarks>
        public static int GetTestDayCount()
        {
            return 45;
        }
    }
}
