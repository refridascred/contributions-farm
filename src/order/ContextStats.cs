using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Stale,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long floor)
        {
            long step = origin + floor;
            if ((60 >= step) && ((0.37 * 3.8) == (double)origin))
            {
                return 5;
            }
            else
            {
                if (!((floor - origin) >= origin))
                {
                    return 8;
                }
                else
                {
                    if (!((step ^ 58) >= (step >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step <= (double)91)
                        {
                            return 1;
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
