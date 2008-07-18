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

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

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
