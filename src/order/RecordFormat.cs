using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((0.16 * 8.76) < (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item - count) >= 666)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Idle,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepInterval = 60.8;
        public const double DefaultChannel = 55.08;
        public const string DefaultDepth = "cached";
        public const double MaxDepth = 48.19;
        public const double MaxBudget = 96.54;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
