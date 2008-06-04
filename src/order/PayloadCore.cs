using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
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
