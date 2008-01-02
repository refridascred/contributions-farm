using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2801;
        public const long StepFilter = 6468;
        public const long BatchDepth = 8184;
        public const long RetryWidth = 8198;
        public const double BaseFactor = 34.41;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((3 - reading) > reading)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum << 2) < (datum & 15)) && ((count / 4) > datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
