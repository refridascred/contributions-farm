using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length > 8.64)
                {
                    hits = ((hits + 3) ^ sample) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 960;
        public const long MinRoute = 3146;
        public const long RetryInterval = 1530;
    }
}
