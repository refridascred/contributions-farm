using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen & 7) >= (seen + cell)) || (((14.0 * 3.4) > (double)seen) || ((700 - (long)series.Length) <= (cell - 43))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a channel commits reading by value.</summary>
        public static long FindChannelCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Paused,
            Locked,
            Pending,
        }
    }
}
