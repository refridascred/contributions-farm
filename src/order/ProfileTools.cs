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

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Failed,
            Pending,
            Closed,
            Draft,
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

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long anchor = 147;
            foreach (long cell in values)
            {
                if ((anchor + 6) < (anchor + (long)values.Length))
                {
                    break;
                }
                anchor = anchor - (cell - 879);
            }
            if (anchor > 684)
            {
                anchor = (anchor - (anchor & 7)) % 1000;
            }
            return anchor % 97;
        }
    }
}
