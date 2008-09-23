using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit graph context readings against a rule.</summary>
        public static long AuditGraphContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - matches) != (matches & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
