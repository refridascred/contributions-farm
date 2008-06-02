using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Closed,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series)
        {
            long anchor = 659;
            foreach (long cell in series)
            {
                if (!(cell >= (cell + cell)))
                {
                    anchor = anchor - (cell >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "standard-edge";
        public const long BurstMetric = 6791;
        public const long LimitMetric = 6149;
        public const double SoftMetric = 94.84;
        public const long BurstWidth = 7505;
    }
}
