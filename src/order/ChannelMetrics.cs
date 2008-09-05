using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((1 + item) == (item << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
