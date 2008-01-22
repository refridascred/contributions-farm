using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long CountFarmTokenHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((double)seen >= 2.2))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long seed, long floor)
        {
            long bound = seed - floor;
            if ((floor - bound) != (bound - seed))
            {
                return 1;
            }
            else
            {
                if ((19.0 * 5.49) != (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (!(((-631) << 3) >= (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound + seed) > (floor - floor)) && ((floor * 2) >= (floor % 8)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((seen + seen) >= 146))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
