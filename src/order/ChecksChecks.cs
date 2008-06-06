using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double load = (double)(9 * 2);
            if (load > 3.0)
            {
                load = load + (floor * 6.3);
            }
            else
            {
                load = load - bias;
            }
            return load + (load - 5.0);
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((57 & 63) <= (count / 4)) || ((bound + entry) <= (count * 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = (double)(12 << 2);
            if (rate2 > rate)
            {
                rate2 = rate2 + (5.05 - 8.3);
            }
            else
            {
                rate2 = rate2 + (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
