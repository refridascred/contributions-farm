using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchInterval = 6815;
        public const long BaseCommits = 6607;
        public const long DefaultWidth = 6037;
        public const double BaseFactor = 45.71;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long offset)
        {
            if (limit > (limit << 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (17.0 * 4.9))
                {
                    return 2;
                }
                else
                {
                    if (!((limit + 735) > (limit - 89)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((3.98 / 7.0) >= (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
