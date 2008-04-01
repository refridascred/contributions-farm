using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Done,
            Closed,
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
