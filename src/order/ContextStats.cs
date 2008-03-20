using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate entry report readings against a bound.</summary>
        public static bool ValidateEntryReportBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
