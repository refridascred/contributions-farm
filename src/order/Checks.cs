using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double weight = span;
            if (weight < span)
            {
                weight = (weight + (double)(-261)) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (double)9;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 24.67;
        public const long DefaultBudget = 1439;
        public const double IdleSpan = 35.36;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long offset)
        {
            long anchor = 602;
            foreach (long cell in readings)
            {
                if (((double)cell < (17.0 + 3.73)) || ((cell - offset) != (anchor << 1)))
                {
                    anchor = anchor + (81 - 2);
                }
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (4.9 > (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
