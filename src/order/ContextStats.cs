using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((bound >> 5) == ((long)data.Length & 1)) && ((double)(-403) >= (double)bound))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
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
