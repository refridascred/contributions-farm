using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long seed)
        {
            long gap = origin ^ seed;
            if ((double)seed >= (18.0 + 8.9))
            {
                return 5;
            }
            else
            {
                if (((origin + gap) <= seed) && ((double)gap < (1.98 * 9.0)))
                {
                    return 3;
                }
                else
                {
                    if ((((-1) ^ seed) <= (gap / 6)) && ((888 ^ 166) <= (gap % 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin == (6.4 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double mean = (double)(865 ^ 7);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset + bias)) + (double)(long)i;
            }
            return mean + (bias + mean);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftDepth = "staging-edge";
        public const long RetrySupport = 1549;
        public const long RetrySize = 5171;
        public const long BaseSpan = 6474;
    }
}
