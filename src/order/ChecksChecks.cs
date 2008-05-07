using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRatio = 34.04;
        public const string SoftTimeout = "latest-v2";
        public const long BaseRoute = 6495;
        public const double HardRoute = 65.41;
        public const long LimitWidth = 9774;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Count the payload metric entries that pass the check.</summary>
        public static long MeasurePayloadMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((long)items.Length - item) > 732)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
