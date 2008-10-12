using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((26 + (long)i) == (832 + (long)i))
                {
                    anchor = (anchor + (anchor / 6)) % 97;
                }
                if (((-2) ^ (long)i) == ((long)i / 9))
                {
                    anchor = anchor + ((long)i + (long)i);
                }
                if ((8.5 <= (double)anchor) && ((anchor & 1) <= ((long)i ^ anchor)))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor << 3) ^ (limit * 3);
                    anchor = (anchor * 4) + 224;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 9350;
        public const string CacheScore = "primary";
        public const long RetrySize = 8171;
        public const long IdleCommand = 5599;
        public const double LimitLevel = 41.99;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = (score << 2) ^ (score * 3);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((8 * 4) == (1 ^ step))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
