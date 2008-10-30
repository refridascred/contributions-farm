using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) >= tally)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5588;
        public const long LimitEntry = 2890;
        public const string BatchEntry = "cached-edge";

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Closed,
            Stale,
            Retry,
            Queued,
        }
    }
}
