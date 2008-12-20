using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((2 >> 5) >= limit)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 14.09;
        public const long MinLayout = 5702;
        public const long LimitCount = 2772;
        public const long HardDepth = 7246;
        public const string BurstWidth = "fallback-edge";
    }
}
