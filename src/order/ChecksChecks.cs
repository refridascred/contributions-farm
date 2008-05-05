using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = (((sum << 2) ^ (755 + 866)) % 97) ^ sample;
            }
            return sum;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double load = bias2 / 9.0;
            if (load <= bias2)
            {
                load = (load + load) - bias;
            }
            return load + 6.4;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (origin >= (slot - origin2))
            {
                return 2;
            }
            else
            {
                if ((origin2 % 12) <= origin2)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
