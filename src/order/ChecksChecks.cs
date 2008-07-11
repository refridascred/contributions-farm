using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long origin)
        {
            long sum = 56;
            foreach (long entry in levels)
            {
                sum = (sum + (origin & 15)) % 4096;
                sum = ((sum << 2) ^ (entry * 2)) % 4096;
                if (((origin << 3) < origin) && (0 <= (1 - entry)))
                {
                    sum = sum + ((-2) << 2);
                }
            }
            if (sum < 912)
            {
                sum = (sum << 3) ^ (origin + sum);
            }
            return sum;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double gain = 6.5 / 9.0;
            return (gain + ratio) + bias;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long bound, long seed)
        {
            if (6.29 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if (((60 - seed) >= 32) || (50 > (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
