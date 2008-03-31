using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

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
