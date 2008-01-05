using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowInterval = 9896;
        public const long HardSize = 8566;
        public const long BaseStats = 3197;
        public const string DefaultStats = "stable-v2";
        public const long CacheStats = 9868;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry + seen) > seen) && ((((long)readings.Length ^ entry) >= ((long)readings.Length ^ 7)) && ((double)entry >= (9.6 * 9.0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + 5) % 101;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
