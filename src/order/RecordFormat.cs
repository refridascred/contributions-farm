using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Paused,
            Done,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxInterval = 5663;
        public const long BurstBuffer = 5706;
        public const double SoftSize = 47.33;
        public const double BurstRatio = 70.97;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((26 + (long)values.Length) >= tally) && ((tally << 1) >= (item % 60))) || (seed <= (item * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
