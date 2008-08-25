using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the commits metrics entries that pass the check.</summary>
        public static long MeasureCommitsMetricsMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= 9.0)
                {
                    seen = ((seen + 1) + item) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultFactor = 29.48;
        public const long CacheEntry = 3652;
        public const string LimitDepth = "legacy-1";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
