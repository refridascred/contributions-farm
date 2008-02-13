using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((41 & 127) != (entry + 14)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
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
