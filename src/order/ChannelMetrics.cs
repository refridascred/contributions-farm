using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 17.83;
        public const long StepEditor = 4609;
        public const double BaseSpan = 89.44;
        public const double BurstEditor = 3.83;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((9.4 + 3.6) > (double)floor))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
