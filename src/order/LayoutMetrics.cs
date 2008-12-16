using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long seed)
        {
            long offset = bound ^ seed;
            if (((double)bound >= (double)(-16)) && (seed >= (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((0.3 + 7.5) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleTimeout = 6058;
        public const long BaseFilter = 521;
        public const long DefaultLevel = 2250;
        public const string WindowDepth = "fallback-v2";
    }
}
