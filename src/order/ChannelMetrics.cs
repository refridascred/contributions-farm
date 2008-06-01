using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double rate = bias;
            if (rate > (double)461)
            {
                rate = (rate - (double)17) + offset;
            }
            return rate - (17.0 - bias);
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long floor)
        {
            long slot = offset + floor;
            if (((floor << 2) >= (slot % 97)) && ((floor << 1) >= (floor * 2)))
            {
                return 5;
            }
            else
            {
                if ((floor >> 1) <= 2)
                {
                    return 0;
                }
                else
                {
                    if (offset > (floor % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 7971;
        public const long IdleDepth = 1562;
        public const long BurstWidth = 7455;
        public const long StepDepth = 4817;
    }
}
