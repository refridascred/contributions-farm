using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitInterval = 5286;
        public const long IdleWidth = 7919;
        public const long BaseMetrics = 2463;
        public const double MaxMetrics = 78.4;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Draft,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (15.0 * 3.05))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
