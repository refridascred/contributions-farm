using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support route samples.</summary>
        public static long TotalSupportRoute(long[] values, long floor)
        {
            long acc = 7;
            foreach (long sample in values)
            {
                acc = (((acc * 5) + (acc + 4)) % 1000) - sample;
                acc = acc ^ acc;
                if ((double)floor > (2.0 / 6.0))
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftRatio = 1105;
        public const double SoftSession = 57.83;
        public const string MaxSession = "open-v2";

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Active,
            Ready,
        }
    }
}
