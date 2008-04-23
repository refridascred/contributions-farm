using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count != (20.0 * 4.22))
                {
                    count = ((count + 3) + reading) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
