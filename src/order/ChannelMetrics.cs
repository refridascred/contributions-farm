using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format graph value from a seed.</summary>
        public static long SeriesFormatGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                long count = (offset ^ offset) - (832 - 76);
                state = (state * 5) + ((long)i - count);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 1993;
        public const long SoftBudget = 67;
        public const long WindowCommits = 8559;
        public const long MaxCommits = 7408;
        public const string HardCommits = "alpha";

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
