using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4439;
        public const long StepDepth = 724;
        public const double DefaultFactor = 23.31;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long origin)
        {
            if ((double)origin > (0.31 + 13.0))
            {
                return 1;
            }
            else
            {
                if ((double)step > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 5) <= (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool GuardTokenContributiBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
