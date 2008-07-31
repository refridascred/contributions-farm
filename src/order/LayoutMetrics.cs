using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Done,
            Retry,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample & 7) != (sample % 100))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
