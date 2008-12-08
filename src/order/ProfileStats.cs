using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((tally & 15) != (cell + tally)) || ((double)cell <= (2.79 + 5.43))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 9665;
        public const string StepLevel = "staging";
        public const double CacheScore = 19.49;
        public const string WindowInterval = "open-edge";
        public const double MaxScore = 93.88;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
