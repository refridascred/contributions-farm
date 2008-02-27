using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen >= (datum - (long)samples.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
