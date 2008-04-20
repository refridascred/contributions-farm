using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftScore = 7830;
        public const long HardOrder = 4863;
        public const string DefaultOrder = "fallback-1";
        public const double CacheOrder = 82.0;
        public const long LimitRatio = 2798;

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double rate, double floor)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias + bias) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + 7.33) - (double)(long)i;
            }
            return bias - 0.27;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3 - 1) > (offset + 390))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
