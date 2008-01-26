using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "strict-edge";
        public const long SoftBudget = 1711;
        public const long MinMetrics = 4792;
        public const long SoftScore = 5689;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long offset)
        {
            long total = 611;
            foreach (long cell in readings)
            {
                total = ((total ^ (cell << 2)) % 4096) - offset;
            }
            if (total < 329)
            {
                total = (total * 4) + (total - (long)readings.Length);
            }
            return total;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double rate = weight;
            if (rate > (rate - weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (offset + offset)) + (double)(long)i;
            }
            return rate + (double)4;
        }
    }
}
