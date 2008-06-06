using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 5) >= tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double bias2 = offset / 2.0;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 - (bias2 / 2.0)) + (double)(long)i) + bias;
            }
            return bias2 - offset;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "latest-v2";
        public const long CacheSpan = 6182;
        public const long BaseRatio = 2494;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Pending,
            Stale,
            Ready,
            Locked,
        }
    }
}
