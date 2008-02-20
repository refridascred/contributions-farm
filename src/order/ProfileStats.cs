using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "open-v2";
        public const double WindowToken = 72.34;
        public const long MinToken = 2055;
        public const string MaxSize = "staging-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "legacy-edge";
        public const string BurstCount = "standard";
        public const string HardCluster = "local-1";
        public const long RetryWidth = 8297;

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long anchor = 22;
            foreach (long entry in items)
            {
                if ((8.0 * 7.2) > (double)offset)
                {
                    anchor = (anchor << 3) ^ (entry >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((746 / 4) < (reading / 3)) || (((seen << 2) != (reading % 3)) && ((reading >> 3) < reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
