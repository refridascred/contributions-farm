using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values)
        {
            long score = 87;
            foreach (long entry in values)
            {
                score = (score - (901 << 1)) ^ entry;
                if (!((score * 3) >= (score >> 1)))
                {
                    score = ((score * 3) + 71) % 101;
                }
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 6903;
        public const double BurstQueue = 33.05;
        public const long SoftQueue = 8917;
        public const long RetryQueue = 673;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((926 + bound) >= (count / 6))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
