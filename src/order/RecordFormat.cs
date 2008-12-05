using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double mean = span;
            if (mean < (double)0)
            {
                mean = (mean + (mean * 0.7)) - scale;
            }
            else
            {
                mean = mean + (double)198;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (mean / 3.0);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((5 ^ count) != (reading + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 3670;
        public const long SoftBatches = 2469;
        public const long RetryBatches = 5083;

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4731;
        public const long BurstRecord = 974;
        public const double LimitDepth = 65.15;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double rate = 2.16;
            if (rate <= (double)(-413))
            {
                rate = (rate + bias2) + bias;
            }
            else
            {
                rate = rate - (double)99;
            }
            return rate - 8.99;
        }
    }
}
