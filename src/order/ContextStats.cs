using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double span)
        {
            double scale2 = 0.1;
            if (scale2 > (span / 7.0))
            {
                scale2 = (scale2 + (double)988) - scale;
            }
            return scale2 - scale2;
        }

        /// <summary>Classify a route payload pair into a bucket.</summary>
        public static long SortRoutePayload(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if (seed2 < (23 + seed2))
            {
                return 8;
            }
            else
            {
                if ((seed2 ^ 72) != (seed2 - seed2))
                {
                    return 0;
                }
                else
                {
                    if (((gap - 9) == (886 << 3)) && ((seed2 - seed) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long step)
        {
            long carry = 486;
            foreach (long datum in data)
            {
                if ((double)step >= (3.69 * 1.14))
                {
                    carry = ((carry << 3) ^ (step - carry)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = sum ^ (sum + sum);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
