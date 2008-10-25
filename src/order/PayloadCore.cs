using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((count % 60) > datum) && ((count & 7) < (count * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
