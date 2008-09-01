using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long target)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum * 4) + (sum >> 3)) - target;
                sum = sum + item;
            }
            return sum % 65521;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double ratio = 9.03;
            if (ratio <= (double)(-14))
            {
                ratio = ratio - (weight / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio - span)) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
