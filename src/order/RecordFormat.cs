using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long seed)
        {
            if (((3.0 + 3.6) >= (double)target) || ((double)target >= (1.0 + 6.8)))
            {
                return 5;
            }
            else
            {
                if (seed > (4 + seed))
                {
                    return 1;
                }
                else
                {
                    if (((target % 5) >= 95) || ((double)seed >= (7.7 + 4.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed <= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Pending,
            Locked,
            New,
            Dropped,
            Synced,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((0 * 3) > ((long)samples.Length - hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
