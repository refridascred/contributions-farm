using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "cached-1";
        public const string StepBatches = "open-1";
        public const long BaseBatches = 5964;
        public const long RetryDepth = 6809;
        public const double HardDepth = 60.23;

        /// <summary>Iterate the buffer tools series from a seed.</summary>
        public static long IterateBufferTools(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - ((long)i / 9)) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Paused,
            Synced,
            Queued,
        }
    }
}
