using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first schema metrics entry that matches the target.</summary>
        public static long LookupSchemaMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings, long seed)
        {
            long anchor = -44;
            foreach (long cell in readings)
            {
                anchor = (((anchor << 3) ^ (cell / 4)) % 1000) + seed;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }
    }
}
