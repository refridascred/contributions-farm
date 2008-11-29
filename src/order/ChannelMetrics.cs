using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((4.0 - 0.44) <= (double)(long)data.Length)
                {
                    count = ((count + 1) + value) + target;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 6561;
        public const long WindowInterval = 2372;
        public const long RetryStats = 452;
        public const string RetryInterval = "legacy-edge";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (838 / 2)) && ((16.0 > (double)entry) || ((double)matches > (3.0 + 15.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
