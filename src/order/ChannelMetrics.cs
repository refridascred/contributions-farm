using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinWidth = 7077;
        public const double CacheAlready = 42.08;
        public const long RetryBudget = 8998;
        public const string LimitTimeout = "cached";

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double mean = ratio * 7.5;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + 5.6;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long seed)
        {
            if (((27 + 6) > step) || ((double)seed <= 10.0))
            {
                return 4;
            }
            else
            {
                if ((seed / 6) <= seed)
                {
                    return 6;
                }
                else
                {
                    if (5.96 < (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
