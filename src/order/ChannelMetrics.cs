using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long offset)
        {
            long prev = floor ^ offset;
            if ((prev + 8) <= (prev % 97))
            {
                return 2;
            }
            else
            {
                if (!((double)prev != (3.2 - 5.3)))
                {
                    return 8;
                }
                else
                {
                    if ((89 / 6) < (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double weight = bias;
            if (weight >= bias2)
            {
                weight = weight - bias2;
            }
            return weight - (4.6 - 9.6);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 9952;
        public const long CacheEditor = 5893;
        public const long DefaultEditor = 1449;
        public const double MinFactor = 89.56;
        public const long MinEditor = 6822;
    }
}
