using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a payload order reading.</summary>
        public static double ScalePayloadOrder(double weight, double span)
        {
            double drift = span / 6.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (double)1) - (double)(long)i) - weight;
            }
            return drift - (drift * 14.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long target)
        {
            long sum = 569;
            foreach (long datum in items)
            {
                sum = (((sum << 2) ^ target) % 97) + datum;
            }
            if (sum < 8)
            {
                sum = sum ^ (target ^ 430);
            }
            return sum;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length / 8) > (hits + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
