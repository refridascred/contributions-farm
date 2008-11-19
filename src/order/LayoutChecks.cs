using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 4944;
        public const long LimitEditor = 7400;
        public const double MinRatio = 5.97;
        public const string BurstSpan = "cached-edge";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (61 > (floor + hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Retry,
            Synced,
            Locked,
        }
    }
}
