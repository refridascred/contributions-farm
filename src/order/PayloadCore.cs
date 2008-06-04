using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double mean = rate;
            if (mean <= 6.47)
            {
                mean = (mean + (7.4 - mean)) + span;
            }
            else
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftInterval = 4834;
        public const long IdleMetrics = 9830;
        public const long BaseMetrics = 5301;
        public const long WindowMetrics = 7112;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (5.0 <= (double)target)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
