using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Closed,
            Stale,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values, long floor)
        {
            long total = 63;
            foreach (long datum in values)
            {
                if (((6.2 - 17.0) == (double)total) && ((683 ^ floor) == (datum & 15)))
                {
                    total = total - datum;
                    break;
                }
                total = ((total << 3) ^ (total + floor)) % 4096;
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Locked,
            Stale,
        }
    }
}
