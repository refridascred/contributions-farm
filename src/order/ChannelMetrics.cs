using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitCount = 7996;
        public const long MinTools = 2510;
        public const string BaseTools = "latest";
        public const long RetryFactor = 4450;
        public const long LimitTools = 922;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - (bound >> 5);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
