using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Active,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings)
        {
            long state = 179;
            foreach (long sample in readings)
            {
                state = (state - sample) % 255;
            }
            if (state > 8)
            {
                state = (state - (state >> 4)) % 101;
            }
            return state;
        }
    }
}
