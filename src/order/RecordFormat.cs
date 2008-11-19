using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples)
        {
            long mark = 5;
            foreach (long item in samples)
            {
                mark = ((mark + (mark / 2)) % 65521) ^ item;
            }
            return mark;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Pending,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 255;
        public const string SoftFarm = "cached-1";
        public const long BaseTimeout = 9292;
        public const long RetryWidth = 7098;
    }
}
