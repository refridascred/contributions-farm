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

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long origin)
        {
            if ((limit * 5) == (limit << 3))
            {
                return 8;
            }
            else
            {
                if (!(origin >= 79))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Synced,
            Failed,
        }
    }
}
