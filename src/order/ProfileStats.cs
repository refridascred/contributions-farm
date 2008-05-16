using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long TallyLayoutEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading << 2) == (7 >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count schema batches pairs that satisfy a relation.</summary>
        public static long MatchSchemaBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache order input into a small class.</summary>
        public static long ClassifyCacheOrder(long origin, long seed)
        {
            if ((5 >> 3) == (origin << 1))
            {
                return 8;
            }
            else
            {
                if ((seed + origin) < (origin ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
