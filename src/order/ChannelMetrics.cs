using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long SeriesCommitsFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
