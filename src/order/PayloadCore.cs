using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 6196;
        public const long BurstLayout = 348;
        public const long WindowLayout = 1889;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 3731;
        public const long RetryCounter = 968;
        public const double MaxScore = 77.43;
        public const long SoftCounter = 5761;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values, long limit)
        {
            long mark = 4;
            foreach (long reading in values)
            {
                mark = ((mark << 3) ^ reading) + limit;
            }
            return mark;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double mean = (double)(0 - (-8));
            if (mean > (double)3)
            {
                mean = (mean + (double)768) + floor;
            }
            else
            {
                mean = mean + (mean - weight);
            }
            return mean + (1.0 + weight);
        }
    }
}
