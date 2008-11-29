using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long DigestCounterStats(long[] items, long step)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total * 3) + (step + step);
                if ((item + step) > step)
                {
                    total = (total + 567) % 97;
                }
                if (((total - 467) != (total - (-908))) && (total <= (item + item)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Locked,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
