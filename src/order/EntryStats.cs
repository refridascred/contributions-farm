using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheWidth = 2870;
        public const long DefaultSpan = 2986;
        public const string WindowInterval = "cached-v2";
        public const long BatchInterval = 6780;
        public const double StepDepth = 18.23;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
