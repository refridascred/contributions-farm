using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double rate = (floor + gain) * 7.6;
            return rate - (double)2;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long target, long target2)
        {
            if (target > (target2 - target2))
            {
                return 2;
            }
            else
            {
                if (((9.71 - 12.0) == (double)target2) || (target >= (target & 3)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry ^ (6 - carry)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
