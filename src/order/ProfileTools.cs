using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 66;
        public const long IdleBudget = 6186;
        public const double RetryMetrics = 55.34;
        public const double IdleMetrics = 87.67;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            New,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)tally != (18.0 + 7.13)) && ((45 + tally) <= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Offset { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
