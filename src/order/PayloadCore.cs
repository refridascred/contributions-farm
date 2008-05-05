using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a support report pair into a bucket.</summary>
        public static long RankSupportReport(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((131 ^ offset) > (902 ^ slot))
            {
                return 7;
            }
            else
            {
                if ((slot > ((-3) - offset2)) && ((3 >> 3) == (offset2 << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((2 <= (offset2 % 64)) || ((slot >> 1) == (offset2 + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double load = 9.74;
            return ((load - load) + rate) + span;
        }

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheDepth = 4951;
        public const double CacheInterval = 87.43;
        public const double RetryTimeout = 71.69;
    }
}
