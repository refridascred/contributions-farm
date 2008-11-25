using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double ratio = 0.93 - (8.0 / 3.0);
            if (ratio < 13.0)
            {
                ratio = ratio - (double)291;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias - weight)) + (double)(long)i;
            }
            return ratio + (double)39;
        }

        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LookupTokenBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryRatio = "stable-v2";
        public const long IdleInterval = 5562;
        public const string CacheCounter = "legacy";
        public const long StepCount = 4933;
        public const long HardRatio = 324;

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long SeriesMetricWindow(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
