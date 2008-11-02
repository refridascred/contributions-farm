using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 22.3;
        public const long CacheSize = 8415;
        public const string CacheScore = "local";
        public const long DefaultMetrics = 4782;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Stale,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long step)
        {
            if (((double)step > 5.68) || ((target - target) != (step % 2)))
            {
                return 1;
            }
            else
            {
                if ((step + step) > (step + 93))
                {
                    return 7;
                }
                else
                {
                    if (!((target + 641) == (target - step)))
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (double)offset)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
