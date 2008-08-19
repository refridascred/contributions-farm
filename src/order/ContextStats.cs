using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample - 4) == (59 & 127)) || !((double)count > 2.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values)
        {
            long mix = 69;
            foreach (long datum in values)
            {
                if (datum >= (mix - mix))
                {
                    mix = (mix * 3) + ((-5) - 4);
                }
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long seed, long seed2)
        {
            if ((seed << 2) < (seed2 + seed))
            {
                return 8;
            }
            else
            {
                if (((double)seed2 < (double)seed) && (seed >= (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
