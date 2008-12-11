using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double load = (double)4 * 1.0;
            if (load < bias)
            {
                load = (load + (load / 8.0)) - offset;
            }
            else
            {
                load = load - bias;
            }
            return load + (double)284;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double mean = offset;
            if (mean < (bias - bias))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean - offset)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many cache payload samples are out of range.</summary>
        public static long AuditCachePayloadGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((20 - 6) >= matches)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
