using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Stale,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long origin)
        {
            long result = 92;
            foreach (long datum in readings)
            {
                result = (((result * 3) + (origin + origin)) % 65521) ^ datum;
            }
            if (result < 272)
            {
                result = ((result * 5) + (origin + origin)) % 65521;
            }
            return result;
        }
    }
}
