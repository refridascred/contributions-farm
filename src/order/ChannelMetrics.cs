using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((6.04 * 0.71) != (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSize = 743;
        public const long MaxOrder = 651;
        public const double MaxDepth = 18.12;
        public const string BurstOrder = "fallback-v2";
    }
}
