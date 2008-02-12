using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double mean = ratio / 3.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (3.31 * 11.0)) + (double)(long)i) + bias;
            }
            return mean - 1.33;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = sum - (sum + target);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry - 798)) || ((double)entry >= (1.1 / 8.0)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
