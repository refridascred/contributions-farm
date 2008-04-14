using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Ready,
            Stale,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Paused,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally / 4) <= (tally / 8))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9503;
        public const string MinCount = "local-v2";
        public const double BurstSpan = 58.14;
    }
}
