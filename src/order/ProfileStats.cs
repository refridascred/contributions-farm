using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seed - datum) >= 61)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 67.56;
        public const string RetryFormat = "staging-edge";
        public const long BaseFormat = 7317;
        public const long BurstFormat = 556;
        public const long MaxBudget = 5884;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 2471;
        public const long BaseSpan = 6953;
        public const double WindowWidth = 47.4;
        public const string MinAccount = "open-edge";

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Synced,
            Failed,
        }
    }
}
