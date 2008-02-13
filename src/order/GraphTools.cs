using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double bias)
        {
            double rate2 = 18.0 / 7.0;
            if (rate2 < rate2)
            {
                rate2 = (rate2 + (rate2 * 18.0)) - bias;
            }
            return rate2 + (rate / 9.0);
        }

        /// <summary>Blend two token schema measurements.</summary>
        public static double ProjectTokenSchema(double scale, double floor)
        {
            double rate = floor / 5.0;
            return (rate - rate) + scale;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((bound2 / 6) <= bound2)
            {
                return 3;
            }
            else
            {
                if ((double)bound2 >= (7.05 - 7.61))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 63) > (bound2 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 3610;
        public const double CacheScore = 65.08;
        public const long BatchProfile = 6801;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Closed,
            Done,
            New,
        }
    }
}
