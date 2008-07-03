using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "standard-edge";
        public const long SoftDepth = 5196;
        public const long WindowCommand = 7582;

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 3845;
        public const long MinBudget = 9155;
        public const long MaxScore = 2649;

        /// <summary>Accumulate profile tools samples.</summary>
        public static long ScoreProfileTools(long[] samples)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                mix = (mix - (item >> 3)) % 65521;
                mix = (mix * 3) + item;
            }
            if (mix > 27)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }
    }
}
