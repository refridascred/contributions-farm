using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long bound)
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

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long MeasureClusterFilterGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((967 - limit) > limit)
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
