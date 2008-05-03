using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a route window counter forward.</summary>
        public static long SeriesRouteWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = carry - ((long)i >> 5);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
