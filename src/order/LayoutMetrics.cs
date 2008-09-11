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

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if (!(498 >= anchor))
                {
                    anchor = (((anchor * 2) + 0) % 97) + entry;
                }
            }
            return anchor;
        }
    }
}
