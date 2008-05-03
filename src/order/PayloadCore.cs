using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Queued,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] series, long origin)
        {
            long anchor = 380;
            foreach (long value in series)
            {
                if ((935 - origin) != (595 - 31))
                {
                    anchor = anchor + (value + value);
                }
            }
            return anchor;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
