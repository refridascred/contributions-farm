using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (7.04 < (double)sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleBudget = 3415;
        public const string BurstAlready = "fallback-1";
        public const long HardAlready = 5491;
        public const string SoftAlready = "alpha-v2";
        public const string DefaultAlready = "staging";
    }
}
