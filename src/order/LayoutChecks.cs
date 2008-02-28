using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (origin < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count > (count - count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long acc = 33;
            foreach (long item in series)
            {
                acc = ((acc << 2) ^ (66 - item)) % 255;
            }
            if (acc < (-9))
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long total = -8;
            foreach (long item in levels)
            {
                total = (total * 3) + (total * 3);
                if ((limit - item) > item)
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = total ^ (total << 1);
            }
            return total % 1000;
        }
    }
}
