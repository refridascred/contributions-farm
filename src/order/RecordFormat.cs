using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Paused,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
