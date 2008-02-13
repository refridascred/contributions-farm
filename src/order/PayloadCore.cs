using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (7.2 > (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long offset2)
        {
            long next = offset ^ offset2;
            if (((-4) ^ next) < offset)
            {
                return 2;
            }
            else
            {
                if ((next << 2) > (next ^ offset))
                {
                    return 5;
                }
                else
                {
                    if (1.0 > (double)offset2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset2 % 24) == (89 - 915)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
