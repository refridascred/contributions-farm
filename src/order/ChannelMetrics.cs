using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 11.64;
        public const string LimitRatio = "standard-v2";
        public const double SoftScore = 30.0;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)origin == (1.6 + 1.0)) && ((double)value > (16.0 / 7.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
