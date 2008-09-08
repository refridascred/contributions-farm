using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Ready,
            Queued,
            Active,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long CountEntryCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
