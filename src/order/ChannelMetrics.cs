using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long offset)
        {
            if (2 < (bound & 31))
            {
                return 6;
            }
            else
            {
                if (2.0 >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (((offset ^ offset) < (bound << 1)) && (bound < (offset + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset != (1.1 * 0.5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSize = 2116;
        public const double BatchRecord = 85.04;
        public const double BurstTimeout = 93.0;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double drift = (double)0 * 8.93;
            if (drift < (drift / 3.0))
            {
                drift = (drift - drift) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - (double)73;
        }
    }
}
