using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 255) > (item + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer support pair into a bucket.</summary>
        public static long RankBufferSupport(long seed, long limit)
        {
            if ((limit + limit) > (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((limit % 16) < (seed + 159))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 2) >= (seed << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "staging";
        public const long IdleStats = 7399;
        public const string BaseInterval = "strict";
        public const long BaseSpan = 2144;
        public const long IdleScore = 1424;
    }
}
