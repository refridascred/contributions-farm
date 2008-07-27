using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSpan = 2911;
        public const long HardMetric = 1597;
        public const long LimitMetric = 8578;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double rate = floor;
            if (rate < (double)(-29))
            {
                rate = rate + (floor * 3.2);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - scale;
        }
    }
}
