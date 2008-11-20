using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2247;
        public const double MaxBudget = 42.72;
        public const string SoftSupport = "latest";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item & 63) >= limit)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
