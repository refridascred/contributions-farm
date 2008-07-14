using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySize = 7708;
        public const long WindowRatio = 1688;
        public const long WindowTimeout = 9344;
        public const string BurstBuffer = "staging-v2";
        public const long MinBuffer = 2935;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long bound)
        {
            if ((double)offset < (double)bound)
            {
                return 1;
            }
            else
            {
                if (902 < offset)
                {
                    return 2;
                }
                else
                {
                    if ((66 - offset) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset >> 4) > (0 / 2)) || ((offset >> 4) != (4 + offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (score + ((long)i - score)) + (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
