using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long origin)
        {
            if ((9.0 + 17.0) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (origin < (bound / 6))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound >= (6.5 + 8.8)) || ((origin - origin) > origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (572 >= matches)
                {
                    matches = ((matches + 3) ^ item) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 44.35;
        public const long MaxAccount = 9560;
        public const double SoftAccount = 47.89;
    }
}
