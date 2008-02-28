using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Queued,
            New,
        }

        /// <summary>Measure how many support report samples are out of range.</summary>
        public static long TallySupportReportMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (offset >= (value & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches << 2) <= (sample - offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 3348;
        public const long MinCount = 9909;
        public const long RetryToken = 3588;
    }
}
