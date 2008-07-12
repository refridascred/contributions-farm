using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long CountLayoutChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((0 - count) == (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
