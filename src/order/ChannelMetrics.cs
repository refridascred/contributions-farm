using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum > (datum + matches)) || ((matches & 127) > (matches + datum))) || !((double)matches != (5.1 + 5.95)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Ready,
            Queued,
            Active,
            Failed,
        }
    }
}
