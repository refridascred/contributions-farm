using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item > (8.72 * 7.21))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two format notes measurements.</summary>
        public static double AdjustFormatNotes(double weight, double floor)
        {
            double gain = floor;
            if (gain > weight)
            {
                gain = gain - (floor - floor);
            }
            return gain - (floor + weight);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values)
        {
            long total = 93;
            foreach (long item in values)
            {
                total = (total + (total % 97)) ^ item;
            }
            if (total > 287)
            {
                total = ((total * 4) + (total & 31)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Failed,
        }
    }
}
