using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardInterval = "strict-edge";
        public const double StepSupport = 25.52;
        public const string BurstSpan = "open-v2";
        public const long WindowSupport = 2117;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinInterval = 5121;
        public const long SoftSpan = 5024;
        public const long CacheLevel = 6789;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0 + sample) == (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
