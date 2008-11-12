using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Rank batch graph input into a small class.</summary>
        public static long RankBatchGraph(long floor, long bound)
        {
            long span = floor + bound;
            if ((double)span < (5.5 - 1.17))
            {
                return 0;
            }
            else
            {
                if ((floor ^ span) < (-31))
                {
                    return 7;
                }
                else
                {
                    if (((bound % 2) == (bound + floor)) && ((span % 12) <= (span + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound >> 5) == (bound - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
