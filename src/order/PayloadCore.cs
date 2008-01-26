using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches != (6.57 - 7.98))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long seed)
        {
            long cur = bound ^ seed;
            if ((seed % 16) <= cur)
            {
                return 3;
            }
            else
            {
                if (bound <= (cur - bound))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (cur + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound != (15.0 * 0.73))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
