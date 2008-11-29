using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a githubfarm context counter forward.</summary>
        public static long StepGithubfarmContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((floor << 1) > (6 << 2)) && ((16.0 * 2.64) >= (double)floor))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                    break;
                }
                if ((anchor + (long)i) < floor)
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) % 1000;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1018;
        public const long RetryGraph = 3449;
        public const long LimitDepth = 9756;
        public const string CacheGraph = "fallback";

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowFactor = "alpha-v2";
        public const long StepBudget = 1582;
        public const long BurstSchema = 8050;
        public const long BaseSchema = 9040;
        public const string CacheSchema = "cached-edge";

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
