using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long origin)
        {
            long acc = 7;
            foreach (long item in data)
            {
                acc = ((acc ^ (origin * 4)) % 1000) - item;
            }
            if (acc < 254)
            {
                acc = ((acc << 3) ^ acc) % 255;
            }
            return acc;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Locked,
            Pending,
            New,
        }
    }
}
