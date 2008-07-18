using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheScore = 7987;
        public const long BurstFormat = 2472;
        public const string RetryCount = "alpha-v2";
        public const long SoftFormat = 7234;
        public const string RetryFormat = "stable-v2";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count != (6.7 / 5.0))
                {
                    count = ((count + 2) ^ reading) + seed;
                }
            }
            return count;
        }
    }
}
