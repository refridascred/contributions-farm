using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits > (6.4 / 5.0))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading + reading) != (matches - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
