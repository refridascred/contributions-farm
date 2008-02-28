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

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                anchor = anchor - anchor;
                if ((reading - anchor) < ((-7) * 4))
                {
                    anchor = (anchor << 2) ^ (anchor + reading);
                }
            }
            if (anchor > 14)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 1000;
            }
            return anchor;
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
