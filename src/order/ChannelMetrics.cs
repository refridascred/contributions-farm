using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (2 > (cell + cell))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Active,
            Ready,
            Done,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
