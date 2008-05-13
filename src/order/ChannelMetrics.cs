using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long RollEntryLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
